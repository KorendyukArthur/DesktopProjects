from .models import Articles, Chat, ChatBron
from django.forms import ModelForm, TextInput, DateTimeInput, Textarea, TimeInput, DateInput, DateTimeField
from django import forms
from django.contrib.admin import widgets
from django import forms

class ArticlesForm(ModelForm):
    class Meta:
        model = Articles
        fields = ['title', 'anons', 'full_text', 'date']

        widgets = {
            'title': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Название статьи'
                }),

            'anons': TextInput(
                attrs={

                    'class': 'form-control',
                    'placeholder': 'Анонс статьи'
                }),

            'date': DateTimeInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Дата публикации'
                }),

            'full_text': Textarea(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Текст статьи'
                }),

        }

class ChatForm(ModelForm):
    class Meta:
        model = Chat
        fields = ['id_user', 'min_text', 'full_text', 'date']

        widgets = {
            'id_user': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Фамилия пользователя'
                }),

            'min_text': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Описание сообщения'
                }),

            'date': DateTimeInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Дата отправки'
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
                  'date_z', 'date_v', 'number_human', 'date_message']

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

            'date_z': forms.DateTimeInput(format=('%Y-%m-%dT%H:%M'),
                 attrs={
                     'type': 'datetime-local',
                     'class': 'form-control datetimepicker-input',
            'data-target': '#datetimepicker7',
                    'placeholder': 'Дата заезда(01.01.2023)'
                }),


            'date_v':  forms.DateTimeInput(format=('%Y-%m-%dT%H:%M'),
                 attrs={'type': 'datetime-local',
                    'class': 'form-control datetimepicker-input',
                    'data-target': '#datetimepicker8'}
                ),


            'number_human': TextInput(
                attrs={
                    'class': 'form-control',
                    'placeholder': 'Количество человек'
                }),
            'date_message': DateTimeInput(format=('%Y-%m-%dT%H:%M'),
                 attrs={'type': 'datetime-local',
                        'class': 'form-control datetimepicker-input',
                    })

        }
