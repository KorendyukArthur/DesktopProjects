from django.contrib.auth import views as auth_views
from django.contrib.auth.views import LoginView, LogoutView
from django.urls import path
from main import views as user_views
from . import views
urlpatterns = [
    path('',views.index, name = 'home'),
    path('about',views.about, name = 'about'),
    path('expindex', views.expindex, name = 'expindex'),
    path('test_html', views.test_html, name = 'test_html'),
    path('contact', views.contact, name='contact'),
    path('users', views.users, name='users'),

    path('register/', user_views.register, name='register'),
    path('profile/', user_views.profile, name='profile'),
    path('login/', LoginView.as_view(template_name='main/login.html'), name='login'),
    path('logout/', LogoutView.as_view(template_name='main/logout.html'), name='logout'),
    path('layout_admin/',views.layout_admin, name = 'layout_admin'),
    path('main_company/',views.main_company, name = 'main_company'),
    path('main_price/',views.main_price, name = 'main_price'),

    path('success', views.success, name='success'),
path('success_chat', views.success_chat, name='success_chat'),

]
