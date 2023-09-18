@extends('layouts.app')
<?php
//Страница второстепенная
?>
@section('content')
    <div class="container col-xxl-8 px-4 py-5">
        <h1 class="display-3 fw-bold"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Контакты компании</font></font></h1>
        <h3 class="fw-normal text-muted mb-3"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Создавайте все, что захотите, с помощью нашей команды</font></font></h3>

        <div class="row flex-lg-row-reverse align-items-center g-5 py-5">
        <div class="col-10 col-sm-8 col-lg-6">
            <img src="bootstrap-themes.png" class="d-block mx-lg-auto img-fluid" alt="Загрузочные темы" width="700" height="500" loading="lazy">
        </div>
        <div class="col-lg-6">
            <h1 class="display-5 fw-bold text-body-emphasis lh-1 mb-3"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Адаптивный левый герой с изображением</font></font></h1>
            <p class="lead"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Быстро создавайте и настраивайте адаптивные сайты, ориентированные на мобильные устройства, с помощью Bootstrap, самого популярного в мире внешнего интерфейса с открытым исходным кодом, включающего переменные и примеси Sass, адаптивную сетку, обширный набор готовых компонентов и мощные плагины JavaScript.</font></font></p>
            <div class="d-grid gap-2 d-md-flex justify-content-md-start">
                <button type="button" class="btn btn-primary btn-lg px-4 me-md-2"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Начальный</font></font></button>
                <button type="button" class="btn btn-outline-secondary btn-lg px-4"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">По умолчанию</font></font></button>
            </div>
        </div>
    </div>
    </div>
@endsection
