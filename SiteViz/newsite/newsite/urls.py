
from django.contrib import admin
from django.contrib.auth import views as auth_views
from django.urls import path, include
from django.conf import settings
from django.conf.urls.static import static
from django.views.i18n import JavaScriptCatalog

urlpatterns = [
    path('admin/', admin.site.urls),
    path('', include('main.urls')),
    path('news/', include("news.urls")),
    path('main_company/', include("news.urls")),

    path('jsi18n', JavaScriptCatalog.as_view(), name='javascript-catalog'),

    ] + static(settings.STATIC_URL, document_root=settings.STATIC_ROOT)


