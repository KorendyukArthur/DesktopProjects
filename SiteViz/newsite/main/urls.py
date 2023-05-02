
from django.urls import path
from . import views
urlpatterns = [
    path('',views.index, name = 'home'),
    path('about',views.about, name = 'about'),
    path('expindex', views.expindex, name = 'expindex'),
    path('test_html', views.test_html, name = 'test_html')

]
