from django.db import models
from django.core.exceptions import ValidationError
from django.core.validators import RegexValidator




class Articles(models.Model):
    title = models.CharField('Название', max_length=50)
    anons = models.CharField('Анонс', max_length=250)
    full_text = models.TextField('Статья')
    date = models.DateTimeField('Дата публикации')

    # возвращает название объекта
    # необходим для вывода из таблиц нормальных данных а не 0 и 1 и 2
    # def __str__(self):
    #   return self.titile

    def __str__(self):
        return self.title

    class Meta:
        verbose_name = 'Новость'
        verbose_name_plural = 'Новости'

    # метод для переадресации пользователей после обновления и редактирования статьи
    def get_absolute_url(self):
        return f'/news/{self.id}'


class Chat(models.Model):
    id_user = models.CharField('id пользователя', max_length=50)
    min_text = models.CharField('Описание', max_length=250)
    full_text = models.TextField('Сообщение')
    date = models.DateTimeField('Дата отправки')

    def __str__(self):
        return self.id_user

    class Meta:
        verbose_name = 'Чат'
        verbose_name_plural = 'Чаты'

    # метод для переадресации пользователей после обновления и редактирования статьи
    def get_absolute_url(self):
        return f'/news/{self.id}'


class ChatBron(models.Model):
    #     CHOICES = ("Пансионат Шепси","Бальнеологический курорт Мацеста","Гранд-Отель","Отель Sea Galaxy Congress & SPA 4*","Санаторий Адлеркурорт"
    # ,"Санаторий Металлург Сочи","Санаторий Зеленая долина","Оздоровительный комплекс AMAKS Курорт «Орбита» (Туапсе)","База отдыха Торнадо","Пансионат Ларимар","Санаторий Бирюза","Санаторно-курортный комплекс Вулан")
    CHOICES = (
        ('US', 'United States'),
        ('FR', 'France'),
        ('CN', 'China'),
        ('RU', 'Russia'),
        ('IT', 'Italy'),
    )
    name_tur = models.CharField('Название путевки', max_length=250,validators=[RegexValidator
        (
        regex='^[а-я]*$',
            message='Username must be Alphanumeric',
            code='invalid_username')])

    surname_user = models.CharField('Фамилия', max_length=50,
    validators = [RegexValidator
        (
        regex='^[а-я]*$',
        message='Username must be Alphanumeric',
        code='invalid_username')])
    name_user = models.CharField('Имя', max_length=50,
    validators = [RegexValidator
        (
        regex='^[а-я]*$',
        message='Username must be Alphanumeric',
        code='invalid_username')])
    surname_2_user = models.CharField('Отчество', max_length=50,
    validators = [RegexValidator
        (
        regex='^[а-я]*$',
        message='Username must be Alphanumeric',
        code='invalid_username')])


    number_user = models.CharField('Контактный номер', max_length=11,
    validators = [RegexValidator
        (
        regex='^[0-9]*$')])


    date_z = models.DateTimeField('Дата заезда')
    date_v = models.DateTimeField('Дата выезда')


    number_human = models.CharField('Количество человек', max_length=11,
    validators = [RegexValidator
        (
        regex='^[0-9]*$')])
    date_message = models.DateTimeField('Дата отправки сообщения')

    def __str__(self):
        return self.surname_user
    class Meta:
        verbose_name = 'Бронь'
        verbose_name_plural = 'Брони'

    # метод для переадресации пользователей после обновления и редактирования статьи
    def get_absolute_url(self):
        return f'/news/{self.id}'

def validat(date_z,date_v):
    if value.date_z <= value.date_v:
        raise ValidationError(
            ("%(value)s is not an even number"),
            params={"value": value},)

