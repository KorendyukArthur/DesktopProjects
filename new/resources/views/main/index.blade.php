@extends('layouts.app')
<?php
    //Страница второстепенная
    ?>
@section('content')
<div class="container">
    <div class="row justify-content-center">

        <div class="col-md-8">
            <div class="card">
                <div class="card-header">_/закажи сайт или зарегистрируйся</div>

                <div class="card-body">
                    @if (session('status'))
                        <div class="alert alert-success" role="alert">
                            {{ session('status') }}
 </div>
                    @endif
                        <div class="position-relative overflow-hidden p-3 p-md-5 m-md-3 text-center bg-body-tertiary">

                                <h2 class="display-3 fw-bold"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Главная страница</font></font></h2>
                                <h3 class="fw-normal text-muted mb-3"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Создавайте все, что захотите, с помощью нашей команды</font></font></h3>
                                <div class="d-flex gap-3 justify-content-center lead fw-normal">
                                    <a class="icon-link" href="#"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">
                                                Узнать больше
                                            </font></font><svg class="bi"><use xlink:href="#chevron-right"></use></svg>
                                    </a>
                                    <a class="icon-link" href="#"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">
                                                Купить
                                            </font></font><svg class="bi"><use xlink:href="#chevron-right"></use></svg>
                                    </a>
                                </div>

                            <div class="product-device shadow-sm d-none d-md-block"></div>
                            <div class="product-device product-device-2 shadow-sm d-none d-md-block"></div>
                        </div>


            </div>
        </div>
    </div>
</div>
@endsection
