
from django.urls import path
from . import views

urlpatterns = [

    path('/news_home', views.news_home, name = 'news_home'),

    path('/news_home_admin',views.news_home_admin, name = 'news_home_admin'),

    path('create', views.create, name='create'),


    path('/chat_home', views.chat_home, name = 'chat_home'),
    path('createchat', views.create_chat, name='createchat'),
    path('create_bron', views.create_bron, name='create_bron'),
    path('create_bron_dop', views.create_bron_dop, name='create_bron_dop'),




    #для отслеживания динамической страницы <int:pk> /news/3
    #класс . as_view() - обязательно

    path('/news_detail/<int:pk>',views.NewsDetailView.as_view(), name='news-detail'),
    path('/news_det/<int:pk>',views.NewsDetailView_admin.as_view(), name='news-detail_admin'),
    path('<int:pk>/update', views.NewsUpdateView.as_view(), name='news-update'),
    path('<int:pk>/delete', views.NewsDeleteView.as_view(), name='news-delete'),
    path('<int:pk>',views.layout_news_admin, name='layout_news_admin'),
    path('successful_registration',views.successful_registration, name ='successful_registration'),


    path('createchatprivate', views.create_chat_private, name='createchatprivate'),
    path('dialogchat', views.dialogchat, name='dialogchat'),

    path('dialogchat_detail/<int:pk>', views.UserDetailView.as_view(), name='dialogchat_detail'),

    path('dialogchat_detail_test/<str:username>', views.dialogchat_detail_test, name='dialogchat_detail_test'),

]

