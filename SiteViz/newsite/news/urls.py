
from django.urls import path
from . import views

urlpatterns = [
    path('',views.news_home, name = 'news_home'),
    path('create', views.create, name='create'),
    #для отслеживания динамической страницы <int:pk> /news/3
    #класс . as_view() - обязательно
    path('<int:pk>',views.NewsDetailView.as_view(), name='news-detail'),
    path('<int:pk>/update', views.NewsUpdateView.as_view(), name='news-update'),
    path('<int:pk>/delete', views.NewsDeleteView.as_view(), name='news-delete')

]

