@extends('layout.layout')


@section('title')
    О компании
@endsection
@section('main_content')
    <h1>Поздравляю вы ввели все данные успешно!!!!</h1>
    <p>Теперь необходимо перейти на главную</p>
    <form method="get" action="/">
        <p><a class="btn btn-secondary" href="/" role="button">View details »</a></p>
    </form>

@endsection
