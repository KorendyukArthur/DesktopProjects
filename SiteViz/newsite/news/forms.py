import username
from werkzeug.routing import ValidationError

from .models import Articles, Chat, ChatBron, ChatPrivate, UploadFile, AppProf1
from django.forms import ModelForm, TextInput, DateTimeInput, Textarea, TimeInput, DateInput, DateTimeField
from django import forms
from django.contrib.admin import widgets
from django import forms

from django.contrib.auth.models import User


class ArticlesForm(ModelForm):
    class Meta:
        model = Articles
        fields = ['title', 'anons', 'full_text']

        widgets = {
            'title': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Название новости'
                }),

            'anons': TextInput(
                attrs={

                    'class': 'form-control',
                    'placeholder': 'Анонс новости'
                }),



            'full_text': Textarea(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Полный текст новости'
                }),

        }

class ChatForm(ModelForm):
    class Meta:
        model = Chat
        fields = ['id_user', 'min_text', 'full_text']

        widgets = {
            'id_user': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': ''
                }),


            'min_text': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Описание сообщения'
                }),


            'full_text': Textarea(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Текст сообщения'
                }),



        }


class SelectDateWidget(forms.DateInput):
    input_tupe = 'date'


class ChatBronForm(forms.ModelForm):
    class Meta:
        model = ChatBron
        fields = ['name_tur', 'surname_user', 'name_user', 'surname_2_user', 'number_user',
                  'date_z', 'date_v', 'number_human']

        widgets = {
            'name_tur': forms.TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Название путевки'
                }),

            'surname_user': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Фамилия'
                }),

            'name_user': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Имя'
                }),

            'surname_2_user': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Отчество'
                }),

            'number_user': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Номер телефона'
                }),

            'date_z': forms.DateTimeInput(format=('%d-%m-%yT%H:%M'),
                 attrs={
                     'type': 'datetime-local',
                     'class': 'form-control datetimepicker-input',
            'data-target': '#datetimepicker7',
                    'placeholder': 'Дата заезда(01.01.2023)'
                }),


            'date_v':  forms.DateTimeInput(format=('%d-%m-%yT%H:%M'),
                 attrs={'type': 'datetime-local',
                    'class': 'form-control datetimepicker-input',
                    'data-target': '#datetimepicker8'}
                ),


            'number_human': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Количество человек'
                }),

        }


class ChatPrivateForm(ModelForm):
    class Meta:
        model = ChatPrivate
        fields = ['user1_id', 'user2_id', 'full_text' ]

        widgets = {
            'user1_id': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Пользователь 1'
                }),

            'user2_id': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Пользователь 2'
                }),

            'full_text': Textarea(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Текст сообщения'
                }),

        }


class UploadFileForm(ModelForm):
    class Meta:
        model = UploadFile
        fields = ['title', 'file' ]



class AppProf1Form(ModelForm):
    class Meta:
        model = AppProf1
        fields = ('last_name', 'first_name', 'father_name_user_ap', 'job_title', 'number_phone')

        widgets = {
            'last_name': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Фамилия'
                }),


            'first_name': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Имя'
                }),

            'father_name_user_ap': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Отчество'
                }),

            'job_title': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Должность'
                }),

            'number_phone': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Номер телефона'
                }),

        }