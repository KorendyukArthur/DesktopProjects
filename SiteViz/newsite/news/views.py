from django.shortcuts import render, redirect
from .models import Articles
from .forms import ArticlesForm
from django.views.generic import DetailView, UpdateView, DeleteView

#передача данных создание класса
class NewsDetailView(DetailView):
    model = Articles
    #шаблон который обрабатывет страницу
    template_name = 'news/deatils_view.html'
    #ключ для шаблона
    context_object_name = 'article'

#Обновление данных
class NewsUpdateView(UpdateView):
    model = Articles
    #шаблон который обнавляет страницу
    template_name = 'news/update.html'
    form_class = ArticlesForm
    #ключ для шаблона
    context_object_name = 'article'

#Удаление данных
class NewsDeleteView(DeleteView):
    model = Articles
    success_url = '/news/'
    #шаблон который обнавляет страницу
    template_name = 'news/delete.html'
    #ключ для шаблона
    context_object_name = 'article'





# Create your views here.
def news_home(request):
    #получение записей, таблица, объекты , все объекты
    #news = Articles.objects.all();
    #получение записей и их сортировка по полю титле
    #news = Articles.objects.order_by('date')
    # получение записей и их сортировка по полю даты, для получения только одной записи
    # получение одной записи
    news = Articles.objects.order_by('date')
    #для получения данных вставляются данные третим параметром
    return render(request, 'news/news_home.html', { 'news' : news })







def create(request):
    error = ''
# получение данных из формы
# проверка на работу метода пост
    if request.method == 'POST':
        form = ArticlesForm(request.POST)
        #метод на проверку правильности данных
        if form.is_valid():
            #сохранение данных
            form.save()
            #переадресация на другую страницу
            return redirect('home')
        else:
            error = 'форма была неверной'


    form = ArticlesForm()
    data = {
        'form': form,
        'error' : error
    }

    return render(request, 'news/create.html',data)