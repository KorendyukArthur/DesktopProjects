<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Все js b veu.js</title>
</head>
<body>

</body>

<style>

</style>

<script>

    let someString = 'string'
    let somenum = 1000
    let someBoole = true
    let somenull = null
    let someundefinde = undefined

    let somarray = [1,2,3,5]
    console.log(somarray);

    let someam = {
        onekey: 1,
        twokey: 2,
        threekey: 3
    }

    somarray.forEach(function(item, index){
        console.log(item,index);
    })
    console.log(someam)

    function  somefoon(){
        return 'some string function'
    }
    console.log(somefoon())
    let p2 = 4
    let person = p2 > 3 ? 'ivan' : 'igor'
    console.log(person)



</script>


</html>
