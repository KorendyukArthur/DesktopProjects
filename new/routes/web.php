<?php

use App\Http\Controllers\Main\IndexController;
use App\Http\Controllers\MainOtherController\AboutController;
use App\Http\Controllers\MainOtherController\ContactController;
use App\Http\Controllers\MainOtherController\OtherController;
use App\Http\Controllers\MainOtherController\ProjectController;
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


Route::group(['namespace' => 'App\Http\Controllers\Main'], function () {
    Route::get('/', IndexController::class);
});

Route::group(['namespace' => 'App\Http\Controllers\MainOtherController'], function () {
    Route::get('/about', AboutController::class);
});
Route::group(['namespace' => 'App\Http\Controllers\MainOtherController'], function () {
    Route::get('/contact', ContactController::class);
});
Route::group(['namespace' => 'App\Http\Controllers\MainOtherController'], function () {
    Route::get('/project', ProjectController::class);
});

Route::group(['namespace' => 'App\Http\Controllers\MainOtherController'], function () {
    Route::get('/other', OtherController::class);
});




Route::get('/user/{id}/{name}',function ($id,$name){
    return 'ID' . $id . 'name' . $name;});


Route::get('/review','App\Http\Controllers\MainOtherController\ReviewController@review')->name('review');
Route::post('/review/check','App\Http\Controllers\MainOtherController\ReviewController@review_check');
Route::get('/successful_up_date','App\Http\Controllers\MainOtherController\ReviewController@successful_up_date')->name('successful-up-date');



Auth::routes();
