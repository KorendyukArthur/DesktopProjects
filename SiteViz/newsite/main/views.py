from django.shortcuts import render
from django.http import HttpResponse
#отвечает за те методы которые будут вызваны припереходе в приложение

def index(request):
    data = {
        "title": 'Главная страница!',
    }
    return render(request, 'main/index.html', data)





def about(request):
    return render(request, 'main/about.html')


def test_html(request):
    return render(request, 'main/test_html.html')

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

