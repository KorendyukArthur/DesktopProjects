from django.core.files.storage import FileSystemStorage
from django.http import HttpResponseRedirect
from django.shortcuts import render, redirect
from .models import Articles, Chat, ChatPrivate, UploadFile
from .forms import ArticlesForm, ChatForm, ChatBron, ChatBronForm, ChatPrivateForm, UploadFileForm
from django.views.generic import DetailView, UpdateView, DeleteView
from django.contrib.auth.models import User
from django.contrib.auth.forms import UserCreationForm
from django.contrib import messages



# передача данных создание класса
class UserDetailView(DetailView):
    model = User
    # шаблон который обрабатывет страницу
    template_name = 'news/dialogchat_detail.html'
    # ключ для шаблона
    context_object_name = 'user1'

class UserDetailView1(DetailView):
    model = User
    # шаблон который обрабатывет страницу
    template_name = 'news/dialogchat_detail_test.html'
    # ключ для шаблона
    context_object_name = 'user1'

# передача данных создание класса
class NewsDetailView(DetailView):
    model = Articles
    # шаблон который обрабатывет страницу
    template_name = 'news/deatils_view.html'
    # ключ для шаблона
    context_object_name = 'article'


# передача данных создание класса
class NewsDetailView_admin(DetailView):
    model = Articles
    # шаблон который обрабатывет страницу
    template_name = 'news/deatils_view_admin.html'
    # ключ для шаблона
    context_object_name = 'article'


# Обновление данных
class NewsUpdateView(UpdateView):
    model = Articles
    # шаблон который обнавляет страницу
    template_name = 'news/update.html'
    form_class = ArticlesForm
    # ключ для шаблона
    context_object_name = 'article'


# Удаление данных
class NewsDeleteView(DeleteView):
    model = Articles
    success_url = '/news/'
    # шаблон который обнавляет страницу
    template_name = 'news/delete.html'
    # ключ для шаблона
    context_object_name = 'article'


# Create your views here.
def news_home(request):
    # получение записей, таблица, объекты , все объекты
    # news = Articles.objects.all();
    # получение записей и их сортировка по полю титле
    # news = Articles.objects.order_by('date')
    # получение записей и их сортировка по полю даты, для получения только одной записи
    # получение одной записи
    if request.user.is_superuser:
        news = Articles.objects.order_by('date')
        # для получения данных вставляются данные третим параметром
        return render(request, 'news/news_home_admin.html', {'news': news})
    else:
        news = Articles.objects.order_by('date')

        # для получения данных вставляются данные третим параметром

        return render(request, 'news/news_home.html', {'news': news})


def news_home_admin(request):
    news = Articles.objects.order_by('date')
    return render(request, 'news/news_home_admin.html', {'news': news})


def layout_news_admin(request):
    if request.user.is_superuser:
        return render(request, 'main/layout_admin.html')
    else:
        return render(request, 'main/layout.html')


def create(request):
    error = ''
    # получение данных из формы
    # проверка на работу метода пост
    if request.method == 'POST':
        form = ArticlesForm(request.POST)
        # метод на проверку правильности данных
        if form.is_valid():
            # сохранение данных
            form.save()
            # переадресация на другую страницу
            return redirect('home')
        else:
            error = 'форма была неверной'

    form = ArticlesForm()
    data = {
        'form': form,
        'error': error
    }

    return render(request, 'news/create.html', data)


def create_bron(request):
    error = ''
    # получение данных из формы
    # проверка на работу метода пост
    if request.method == 'POST':
        form = ChatBronForm(request.POST)
        # метод на проверку правильности данных
        if form.is_valid():
            # сохранение данных
            name_tur = form.cleaned_data['name_tur']

            form.save()
            # переадресация на другую страницу
            return redirect('successful_registration')
        else:

            error = 'форма была неверной'

    form = ChatBronForm()
    data = {
        'form': form,
        'error': error
    }

    return render(request, 'news/create_bron.html', data)


def create_chat(request):
    error = ''
    # получение данных из формы
    # проверка на работу метода пост

    if request.method == 'POST':
        form = ChatForm(request.POST)

        # метод на проверку правильности данных
        if form.is_valid():
            # сохранение данных
            form.save()
            # переадресация на другую страницу
            return redirect('home')
        else:
            error = 'форма была неверной'

    form = ChatForm()
    data = {
        'form': form,
        'error': error
    }

    return render(request, 'news/createchat.html', data)

def chat_home(request):
    if request.user.is_superuser:
        news = Chat.objects.order_by('id')
        # для получения данных вставляются данные третим параметром
        return render(request, 'news/chat_home.html', {'news': news})
    else:
        news = Chat.objects.order_by('id')
        # для получения данных вставляются данные третим параметром
        return render(request, 'news/news_home.html')



def create_bron_dop(request):
    error = ''
    # получение данных из формы
    # проверка на работу метода пост
    if request.method == 'POST':
        form = ChatBronForm(request.POST)
        # метод на проверку правильности данных
        if form.is_valid():
            # сохранение данных
            name_tur = form.cleaned_data['name_tur']

            form.save()
            # переадресация на другую страницу
            return redirect('successful_registration')
        else:

            error = 'Данные были введены не верно! Пожалуйста убедитесь в правильности данных'

    form = ChatBronForm()
    data = {
        'form': form,
        'error': error
    }

    return render(request, 'news/create_bron.html', data)

def successful_registration(request):
    return render(request, 'news/successful_registration.html')




def create_chat_private(request):

    error = ''
    # получение данных из формы
    # проверка на работу метода пост

    if request.method == 'POST':
        form = ChatPrivateForm(request.POST)

        # метод на проверку правильности данных
        if form.is_valid():
            # сохранение данных
            form.save()
            # переадресация на другую страницу
            messages.success(request, 'Сообщение было доставлено!!')
        else:
            error = 'форма была неверной'
    s = request.user
    form = ChatPrivateForm()
    ctp = ChatPrivate.objects.filter(user1_id = 'sadmins',user2_id = s ).order_by('date').values() | ChatPrivate.objects.filter(user1_id = s ).order_by('date').values()

    data = {
        'form': form,
        'error': error,
        'ctp': ctp,

    }

    return render(request, 'news/createchatprivate.html', data)


def dialogchat(request):
    users_list = User.objects.all()
    news = User.objects.order_by('id')
    # для получения данных вставляются данные третим параметром
    return render(request, 'news/dialogchat.html', {'users_list': users_list})





def dialogchat_detail_test(request,username):
    error = ''
    # получение данных из формы
    # проверка на работу метода пост


    if request.method == 'POST':
        form = ChatPrivateForm(request.POST)
        dt = User(request.GET)


        # метод на проверку правильности данных
        if form.is_valid():
            # сохранение данных
            form.save()
            # переадресация на другую страницу
        else:
            error = 'форма была неверной'


    obj = ChatPrivate.objects.filter(user1_id = 'sadmins', user2_id = username).order_by('date').values()| ChatPrivate.objects.filter(user2_id = 'sadmins', user1_id = username).order_by('date').values()

    form = ChatPrivateForm()
    dt = User()
    dt1 = UserDetailView()
    data = {
        'form': form,
        'dt' : dt,
        'username' : username,
        'obj': obj,
        'error': error
    }

    return render(request, 'news/dialogchat_detail_test.html', data)


def model_form_upload(request):
    if request.method == 'POST':
        form = UploadFileForm(request.POST, request.FILES)
        if form.is_valid():
            form.save()
            return redirect('home')
    else:
        form = UploadFileForm()
    return render(request, 'news/upload_file.html', {
        'form': form
    })


def view_upload_file(request):
  documents = UploadFile.objects.all()
  return render(request, 'news/view_upload_file.html', {'documents': documents})



def download_file(request,path):
        path = open( 'rb')

