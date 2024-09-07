<?php
include 'nomefile.php'; // per collegare qualunque tipo di file
require 'nomefile.php'; //stessa cosa di include solo che se non trova il file blocca TUTTO anzichè semplicemente saltare il codice




echo "ciao!"; //stampare a schermo
$stringa1 = "come";
$stringa2 = "va?";

$stringaConcatenata = $stringa1." ".$stringa2 //concatenare le stringhe
echo $stringaConcatenata

echo "$stringa1 va?"; //altro trucchetto per concatenare(NON FUNZIONA CON GLI APICI SINGOLI)

$numeroCaratteri = strlen($stringa1); //contare i caratteri
$numeroParole = str_word_count($stringa1);//contare parole

$stringaAlContrario = strrev($stringa1); //stringa al contrario

$posizioneParola = strpos($stringaConcatenata, $stringa2); //ritorna il numero del carattere dove parte la stringa2

$rimpiazzareParola = str_replace("va", "stai", $stringaConcatenata);//cambia "va" con "stai" nella stringa $stringaConcatenata

$num = 12.34;
echo var_dump($num); //stampa a schermo il tipo di variabile e il contenuto

echo is_float($num); //stampa 1 se è vero 0 se è falso
echo is_numeric($num); //stampa 1 se è un numero 0 se non lo è

$str = (string)$num; //str conterrà il valore di $num in stringa

define("PGRECO", 3.14, true); //crea costanti, il terzo parametro è il case sensitive

$array = array("ciao", 23, true, 34, "lol");//creare un array


print_r($array); // per stampare l'array, NON USARE echo

echo $array[2]; //stampare il terzo elemento 

echo count($array); //stampa quanti elementi ci sono nell'array

sort($array); //ordina l'array in senso crescente
rsort($array); //ordina l'array in senso decrescente

array_push($array, "yoo"); //aggiunge un elemento

$array2 = array("weee", 45);
$array3 = array_merge($array,$array2); //unisce gli array

unset($array[0]); //toglie un valore nell'array trasformandolo in NUL (ora la posizione 0 è NULL)

array_splice($array, 2,2);//dalla posizione 2 toglie due elementi (ora l'elemento 2 e 3 non ci sono più e gli altri scalano)

$obj = array(                  //creare un oggetto
    "name" => "Dario", 
    "age" => 17,
    "where" => "Vicenza"
);

echo $obj['name']; //stampa il valora name

$array = array(                          //array di oggetti
    array("name" => "Dario", "age" => 17,"where"=>"Vicenza"),  //posizione 0
    array("casa" => "appartamento", "stato"=>"Italia") //posizione 1
     
);

echo $array[1]['casa']; //stamperà appartamento



if($array[1]['name'] == "Dario" && 1==1 ){ //IF
 echo "Il mio nome è Dario";

}else if ($array[1]['name'] != "Dario" || 2!=2){
    echo "Il mio nome non è Dario";
}

switch($num){  //SWITCH
    case 1:
        echo "ciao1";
    break;
    case 2:
        echo "ciao2";
    break;
    default:
        echo "ciao";
    break;

}

echo "<p> Codice HTML! <p>"; //puoi generare codice HTML!
?>


 <h1>TITOLO HTML<h1> 



<?php
//al di fuori di php è HTML!

$bool = true;
while($bool){     //WHILE

    $bool = false;

}
bool = 1;

do{             //DO WHILE
    echo "ciao"
    bool++;
}while(bool<3);

for($i=0; $i<10; i++){
    echo $i."<br>";   //uso HTML per andare a capo concatenando il codice
}
?>
<ul> 
    <?php //crea una lista con tutti gli elementi di array
$count = 1
foreach($array as $el){ //FOR EACH
    ?>

    <li>echo $el." ha posizione ".$count."<br>";<li>

    <?php
    $count++;
}

    ?>
</ul>

<?php
$n1 = "come";
$n2 = "cacca"; //cerare funzioni
function write($N1, $N2= "stai"){ //qualunque sia il secondo paramentro sarà "stai"
    echo $N1.$N2;
    return $N1.$N2;
}
write($n1, $n2);


$GLOBALS['cioa'] = "ciaoo"; //le variabili globali servono per identificare valori da più fonti come per esempio diversi file separati, qui stiamo modificando la variabile globale ciao in "ciaoo"






?>