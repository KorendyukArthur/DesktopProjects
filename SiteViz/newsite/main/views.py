from django.shortcuts import render
from django.http import HttpResponse
#отвечает за те методы которые будут вызваны припереходе в приложение

from django.shortcuts import render, redirect
from django.contrib import messages
from django.contrib.auth.decorators import login_required
from .forms import UserRegisterForm


from django.contrib.auth.models import User

def index(request):
    data = {
        "title": 'Главная страница ООО Центр Хранения Данных ',
    }
    return render(request, 'main/index.html', data)


def about(request):
    return render(request, 'main/about.html')

def main_price(request):
    return render(request, 'main/main_price.html')

def main_company(request):
    return render(request, 'main/main_company.html')

def test_html(request):
    return render(request, 'main/test_html.html')

def success(request):
    return render(request, 'main/success.html')

def success_chat(request):
    return render(request, 'main/success_chat.html')


def expindex(request):
    data = {
        "title": 'Главная страница!',
        "values": ['Some', 'Hellow', '123', '4000 rub'],
        "obj": {
            'car': 'bmw',
            'model': 'x5',
            'vers': 'f15'
        }

    }

    # возврат html шаблона, первый параметр реквестБ второй название шаблона
    return render(request, 'main/expindex.html', data)


def contact(request):
    return render(request, 'main/contact.html')

def users(request):
    return render(request, 'main/register.html')

def register(request):
    if request.method == 'POST':
        form = UserRegisterForm(request.POST)
        if form.is_valid():
            form.save()
            username = form.cleaned_data.get('username')

            messages.success(request, f'Ваш аккаунт создан: можно войти на сайт.')
            return redirect('login')
    else:
        form = UserRegisterForm()
    return render(request, 'main/register.html', {'form': form})
@login_required
def profile(request):
    return render(request, 'main/profile.html')
    #if request.user.is_anonymous:
     #   return render(request, 'main/register.html')
    #else:
     #   if request.user == admin':
      #      return render(request, 'main/index.html')
       # else:
def layout_admin(request):
    if request.user.is_superuser:
        return render(request, 'main/layout_admin.html')
    else:
        return render(request, 'main/layout.html')

def contact_default(self):
    return self.user.username