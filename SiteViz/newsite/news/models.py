from django.db import models

class Articles(models.Model):

    title = models.CharField('Название', max_length=50)
    anons = models.CharField('Анонс', max_length=250)
    full_text = models.TextField('Статья')
    date = models.DateTimeField('Дата публикации')

    # возвращает название объекта
    # необходим для вывода из таблиц нормальных данных а не 0 и 1 и 2
    #def __str__(self):
    #   return self.titile

    def __str__(self):
        return self.title


    class Meta:
        verbose_name = 'Новость'
        verbose_name_plural = 'Новости'

    #метод для переадресации пользователей после обновления и редактирования статьи
    def get_absolute_url(self):
        return f'/news/{self.id}'