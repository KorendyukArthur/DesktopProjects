# Generated by Django 4.2.1 on 2023-05-19 10:00

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('news', '0006_alter_chatbron_date_message_alter_chatbron_date_v_and_more'),
    ]

    operations = [
        migrations.AlterField(
            model_name='chatbron',
            name='name_tur',
            field=models.CharField(max_length=250, verbose_name='Название путевки'),
        ),
        migrations.AlterField(
            model_name='chatbron',
            name='number_human',
            field=models.CharField(max_length=10, verbose_name='Количество человек'),
        ),
    ]
