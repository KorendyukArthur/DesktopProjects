# Generated by Django 4.2.1 on 2023-05-26 10:17

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('main', '0001_initial'),
    ]

    operations = [
        migrations.AlterField(
            model_name='profile',
            name='image',
            field=models.ImageField(default='1_democr.jpg', upload_to='profile_pics'),
        ),
    ]
