import datetime

import username
from django.db import models
from django.core.exceptions import ValidationError
from django.core.validators import RegexValidator
from pip._internal.cli import parser



class Articles(models.Model):
    title = models.CharField('Название', max_length=50)
    anons = models.CharField('Анонс', max_length=250)
    full_text = models.TextField('Текст новости')
    date = models.DateTimeField(auto_now_add=True)

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
    id_user = models.CharField('Фамилия пользователя', max_length=50)
    min_text = models.CharField('Описание', max_length=250)
    full_text = models.TextField('Сообщение')
    date = models.DateTimeField(auto_now_add=True)



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
        regex='^[а-яА-ЯёЁ\s]*$',
            message='Username must be Alphanumeric',
            code='invalid_username')])

    surname_user = models.CharField('Фамилия', max_length=50,
    validators = [RegexValidator
        (
        regex='^[а-яА-ЯёЁ]*$',
        message='Username must be Alphanumeric',
        code='invalid_username')])
    name_user = models.CharField('Имя', max_length=50,
    validators = [RegexValidator
        (
        regex='^[а-яА-ЯёЁ]*$',
        message='Username must be Alphanumeric',
        code='invalid_username')])
    surname_2_user = models.CharField('Отчество', max_length=50,
    validators = [RegexValidator
        (
        regex='^[а-яА-ЯёЁ]*$',
        message='Username must be Alphanumeric',
        code='invalid_username')])


    number_user = models.CharField('Контактный номер', max_length=11,
    validators = [RegexValidator
        (
        regex='^[0-9]*$')])

    date_v = models.DateTimeField('Дата выезда')

    date_z = models.DateTimeField('Дата заезда')





    number_human = models.CharField('Количество человек', max_length=2,
    validators = [RegexValidator
        (
        regex='^[0-9]*$')])
    date_message = models.DateTimeField(auto_now_add=True)

    def __str__(self):
        return self.surname_user
    class Meta:
        verbose_name = 'Бронь'
        verbose_name_plural = 'Брони'

    # метод для переадресации пользователей после обновления и редактирования статьи
    def get_absolute_url(self):
        return f'/news/{self.id}'

class ChatPrivate(models.Model):


    user1_id = models.CharField('Идентификатор пользователя', max_length=50)
    user2_id = models.CharField('Идентификатор администратора', max_length=50)
    full_text = models.TextField('Сообщение')
    date = models.DateTimeField(auto_now_add=True)

    def __str__(self):
        return self.user1_id

    class Meta:
        verbose_name = 'ОбщийЧат'
        verbose_name_plural = 'ОбщиеЧаты'

    # метод для переадресации пользователей после обновления и редактирования статьи
    def get_absolute_url(self):
        return f'/news/{self.user1_id}'

class UploadFile(models.Model):
    title = models.CharField(max_length=50, blank=True)
    file = models.FileField(upload_to='documents/')
    uploaded_at = models.DateTimeField(auto_now_add=True)

    def __str__(self):
        return self.title

    class Meta:
        verbose_name = 'ОбщийЧат'
        verbose_name_plural = 'ОбщиеЧаты'

    # метод для переадресации пользователей после обновления и редактирования статьи
    def get_absolute_url(self):
        return f'/news/{self.id}'



class UploadFileDoc (models.Model):
    title = models.CharField(max_length=50, blank=True)
    file = models.FileField(upload_to='documents/')
    uploaded_at = models.DateTimeField(auto_now_add=True)

    def __str__(self):
        return self.title

    class Meta:
        verbose_name = 'ОбщийЧат'
        verbose_name_plural = 'ОбщиеЧаты'



class AppProf1(models.Model):

    last_name= models.CharField('Фамилия пользователя', max_length=50,  validators=[RegexValidator
        (
        regex='^[а-яА-ЯёЁ]*$',
        message='Username must be Alphanumeric',
        code='invalid_username')])

    first_name = models.CharField('Имя', max_length=50,
                                    validators=[RegexValidator
                                        (
                                        regex='^[а-яА-ЯёЁ\s]*$',
                                        message='Username must be Alphanumeric',
                                        code='invalid_username')])

    father_name_user_ap = models.CharField('Отчество', max_length=50,
                                    validators=[RegexValidator
                                        (
                                        regex='^[а-яА-ЯёЁ]*$',
                                        message='Username must be Alphanumeric',
                                        code='invalid_username')])

    job_title = models.CharField('Должность', max_length=50,
                                      validators=[RegexValidator
                                          (
                                          regex='^[а-яА-ЯёЁ]*$',
                                          message='Username must be Alphanumeric',
                                          code='invalid_username')])

    number_phone = models.CharField('Номер телефона', max_length=11,
                                    validators=[RegexValidator
                                        (
                                        regex='^[0-9]*$')])
    uploaded_at1 = models.DateTimeField(auto_now_add=True)



    def __str__(self):
        return self.last_name

    class Meta:
        verbose_name = 'Заявка'
        verbose_name_plural = 'Заявки'

    # метод для переадресации пользователей после обновления и редактирования статьи
    def get_absolute_url(self):
        return f'/news/{self.id}'