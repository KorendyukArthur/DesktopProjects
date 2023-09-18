@extends('layouts.layout')

@section('main_content')

    <div class="bg-white">
        <div
            class="d-flex flex-column flex-md-row align-items-center p-3 px-md-4 mb-3 bg-secondary border-bottom shadow-sm">
            <h5 class="my-0 mr-md-auto text-white font-weight-normal"><span style="vertical-align: inherit;"><span
                        style="vertical-align: inherit;">Название компании</span></span></h5>
            <nav class="my-2 my-md-0 mr-md-3">
                <a class="btn btn-outline-warning text-white" href="/"><span style="vertical-align: inherit;"><span
                            style="vertical-align: inherit;">Главная страница</span></span></a>
                <a class="btn btn-outline-warning text-white" href="/about"><span
                        style="vertical-align: inherit;"><span style="vertical-align: inherit;">О компании</span></span></a>
                <a class="btn btn-outline-warning text-white" href="/contact"><span
                        style="vertical-align: inherit;"><span style="vertical-align: inherit;">Контакты </span></span></a>

                <a class="btn btn-outline-warning text-white" href="/present"><span
                        style="vertical-align: inherit;"><span
                            style="vertical-align: inherit;">Проекты</span></span></a>

                <a class="btn btn-outline-warning text-white" href="/other"><span
                        style="vertical-align: inherit;"><span style="vertical-align: inherit;">Другое</span></span></a>
            </nav>
            <a class="btn btn-outline-warning" href="/review"><span style="vertical-align: inherit;"><span
                        style="vertical-align: inherit;">Отзывы</span></span></a>
        </div>
    </div>

    <div class="container">
        @yield('main_content')
    </div>

@endsection
