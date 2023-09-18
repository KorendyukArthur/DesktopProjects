@extends('layouts.app')

@section('content')

    <div>
        <div>
            @if($errors->any())
            <div class="alert alert-danger">
                <ul>
                    @foreach($errors->all() as $error)
                        <li>{{ $error }}</li>
                    @endforeach
                </ul>
            </div>

            @endif
        </div>
    </div>
        <form method="post" action="/review/check">
            @csrf

<div class="container ">
    <h2>Введите ваш отзыв!!</h2>
    <input type="email" name="email" id="email" placeholder="Введите email" class='form-control'><br>
    <input type="text" name="subject" id="subject" placeholder="Введите отзыв" class='form-control'><br>
    <textarea name="message" id="message" placeholder="Введите сообщение" class='form-control'></textarea><br>
    <button type="submit" class="btn btn success">Отправить </button>

</div>

        </form>
        <h1>Все отзывы</h1>

        @foreach($name_reviews as $el)
            <div class="alert alert-warning">
                <h3>{{$el->subject}}</h3>
                <b>{{$el->email}}</b>
                <p>{{$el->message}}</p>
            </div>
        @endforeach


    </div>
@endsection

