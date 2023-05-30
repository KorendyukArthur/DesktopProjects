# Generated by Django 4.2.1 on 2023-05-18 14:26

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('news', '0003_chat'),
    ]

    operations = [
        migrations.CreateModel(
            name='ChatBron',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name_tur', models.CharField(default='Пансионат Шепси', max_length=250, verbose_name='Название путевки')),
                ('surname_user', models.CharField(max_length=50, verbose_name='Фамилия')),
                ('name_user', models.CharField(max_length=50, verbose_name='Имя')),
                ('surname_2_user', models.CharField(max_length=50, verbose_name='Отчество')),
                ('number_user', models.CharField(max_length=50, verbose_name='Контактный номер')),
                ('date_z', models.DateField(verbose_name='Дата заезда')),
                ('date_v', models.DateField(verbose_name='Дата выезда')),
                ('number_human', models.CharField(max_length=250, verbose_name='Количество человек')),
                ('date_message', models.DateField(verbose_name='Дата отправки сообщения')),
            ],
            options={
                'verbose_name': 'Бронь',
                'verbose_name_plural': 'Брони',
            },
        ),
    ]