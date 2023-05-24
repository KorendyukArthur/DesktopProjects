# Generated by Django 4.2.1 on 2023-05-23 20:04

import django.core.validators
from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('news', '0008_alter_chatbron_name_tur'),
    ]

    operations = [
        migrations.AlterField(
            model_name='chatbron',
            name='date_message',
            field=models.DateTimeField(verbose_name='Дата отправки сообщения'),
        ),
        migrations.AlterField(
            model_name='chatbron',
            name='date_v',
            field=models.DateTimeField(verbose_name='Дата выезда'),
        ),
        migrations.AlterField(
            model_name='chatbron',
            name='date_z',
            field=models.DateTimeField(verbose_name='Дата заезда'),
        ),
        migrations.AlterField(
            model_name='chatbron',
            name='name_tur',
            field=models.CharField(max_length=250, validators=[django.core.validators.RegexValidator(code='invalid_username', message='Username must be Alphanumeric', regex='^[а-я]*$')], verbose_name='Название путевки'),
        ),
        migrations.AlterField(
            model_name='chatbron',
            name='name_user',
            field=models.CharField(max_length=50, validators=[django.core.validators.RegexValidator(code='invalid_username', message='Username must be Alphanumeric', regex='^[а-я]*$')], verbose_name='Имя'),
        ),
        migrations.AlterField(
            model_name='chatbron',
            name='surname_2_user',
            field=models.CharField(max_length=50, validators=[django.core.validators.RegexValidator(code='invalid_username', message='Username must be Alphanumeric', regex='^[а-я]*$')], verbose_name='Отчество'),
        ),
        migrations.AlterField(
            model_name='chatbron',
            name='surname_user',
            field=models.CharField(max_length=50, validators=[django.core.validators.RegexValidator(code='invalid_username', message='Username must be Alphanumeric', regex='^[а-я]*$')], verbose_name='Фамилия'),
        ),
    ]
