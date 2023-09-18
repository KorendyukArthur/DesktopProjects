<?php

namespace App\Http\Controllers;

use App\Models\ContactModel;
use Illuminate\Http\Request;

class MainController extends Controller
{
    public function home()
    {
        return view('home');
    }
    public function about(){
        return view('about');
    }

    public function present(){
        return view('present');
    }

    public function contact(){
        return view('contact');
    }
    public function other(){
        return view('other');

    }


    public function review(){
        $reviews = new ContactModel();
        return view('review',['name_reviews'=>$reviews->all()]);
    }
    public function  successful_up_date(){
        return view('successful_up_date');
    }
    public function review_check(Request $request){
        // проверка, валидация
        $vaild = $request->validate([
            'email' => 'required|min:4|max:100',
            'subject'=>'required|min:4|max:100',
            'message'=>'required|min:10|max:500'
        ]);

        $review_contact = new ContactModel();
        $review_contact->email = $request->input('email');
        $review_contact->subject = $request->input('subject');
        $review_contact->message = $request->input('message');

        $review_contact->save();
        return redirect()->route('successful-up-date');

    }

}
