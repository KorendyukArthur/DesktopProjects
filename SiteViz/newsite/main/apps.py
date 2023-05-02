from django.apps import AppConfig
#глобальные настроки для приложения

class MainConfig(AppConfig):
    default_auto_field = 'django.db.models.BigAutoField'
    name = 'main'
