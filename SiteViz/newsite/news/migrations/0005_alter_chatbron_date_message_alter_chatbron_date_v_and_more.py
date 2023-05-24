# Generated by Django 4.2.1 on 2023-05-19 07:38

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('news', '0004_chatbron'),
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
            field=models.CharField(choices=[('US', 'United States'), ('FR', 'France'), ('CN', 'China'), ('RU', 'Russia'), ('IT', 'Italy')], default='Пансионат Шепси', max_length=250, verbose_name='Название путевки'),
        ),
    ]
