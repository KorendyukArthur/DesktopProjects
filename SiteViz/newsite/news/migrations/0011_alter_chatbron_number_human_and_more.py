# Generated by Django 4.2.1 on 2023-05-26 10:17

import django.core.validators
from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('news', '0010_alter_chatbron_number_human_and_more'),
    ]

    operations = [
        migrations.AlterField(
            model_name='chatbron',
            name='number_human',
            field=models.CharField(max_length=11, validators=[django.core.validators.RegexValidator(regex='^[0-9]*$')], verbose_name='Количество человек'),
        ),
        migrations.AlterField(
            model_name='chatbron',
            name='number_user',
            field=models.CharField(max_length=11, validators=[django.core.validators.RegexValidator(regex='^[0-9]*$')], verbose_name='Контактный номер'),
        ),
    ]
