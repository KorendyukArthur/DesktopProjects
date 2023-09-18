<?php

namespace App\Http\Controllers\MainOtherController;

use App\Http\Controllers\Controller;

class ProjectController extends Controller
{
    public function __invoke()
    {
        return view('main_view.project');
    }
}
