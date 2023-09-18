<?php

use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "web" middleware group. Make something great!
|
*/




Route::get('/user/{id}/{name}',function ($id,$name){
        return 'ID' . $id . 'name' . $name;});



Route::get('/','App\Http\Controllers\MainController@home');
Route::get('/about','App\Http\Controllers\MainController@about');
Route::get('/contact','App\Http\Controllers\MainController@contact');
Route::get('/review','App\Http\Controllers\MainController@review')->name('review');
Route::post('/review/check','App\Http\Controllers\MainController@review_check');
Route::get('/successful_up_date','App\Http\Controllers\MainController@successful_up_date')->name('successful-up-date');

Route::get('/present','App\Http\Controllers\MainController@present');
Route::get('/other','App\Http\Controllers\MainController@other');



Auth::routes();

Route::get('/home', [App\Http\Controllers\HomeController::class, 'index'])->name('home');
