import java.util.*

fun main(args: Array<String>) {

    /** EXERCICI01
     *
     *
    var equal = false
    println("QUIN ÉS EL NÚMERO MÉS GRAN")
    print("Entra el primer número->")
    val s = Scanner(System.`in`)
    var n = s.nextInt()
    print("Entra el segon número->")
    var n1 = s.nextInt()
    if (n1>n) n = n1;
    else if (n1 == n) equal = true;
    print("Entra el tercer número->")
    n1 = s.nextInt()
    if (n1 > n)
    {
        n = n1;
        equal = false;
    }
    else if (n1 == n) equal = true;
    print("El numero més gran es-> $n")
    if (equal) println(" i apareix més d'un cop")

    **/


    /** EXERCICI02
    val s = Scanner(System.`in`)
    println("Entra dos numeros:")
    var n1 = s.nextInt()
    var n2 = s.nextInt()
    var n = n1 - n2;
    if (n < 0) println(n * -1);
    else println(n);
    **/

    /** EXERCICI03
    val s = Scanner(System.`in`)
    println("Entra dos numeros:")
    var n1 = s.nextInt()
    var n2 = s.nextInt()
    if (n1 == 0 || n2 == 0) throw Exception("ERROR: Hay un 0")
    if (n1 % n2 == 0 || n2 % n1 == 0) println("Son divisors")
    else println("No son divisors")
    **/

    /** EXERCICI04
    val s = Scanner(System.`in`)
    println("Introduïu un any: ");
    var any = s.nextInt()
    print(any)
    if ((any % 4 == 0 && any % 100 != 0) || (any % 400 == 0)) println(" és un any de traspàs.")
    else println(" no és un any de traspàs.")
    **/

    /** EXERCICI05
    val s = Scanner(System.`in`)
    println("Pasar segons a dies, hores:minuts:segons");
    println("Entra els segons->");
    var n = s.nextInt()
    var d = n / 86400
    n %= 86400
    var h = n / 3600
    n %= 3600
    var m = n / 60
    var seg = n % 60;

    val formattedString = "${d}, ${h.toString().padStart(2, '0')}:${m.toString().padStart(2, '0')}:${seg.toString().padStart(2, '0')}"
    println(formattedString)
    **/

    /** EXERCICI06
    val sca = Scanner(System.`in`)
    println("Entreu una hora del dia amb el següent format hh:mm:ss");
    var str = sca.nextLine()
    val parts = str.split(":");
    var h = parts[0].toInt()
    var m = parts[1].toInt()
    var s = parts[2].toInt()

    if (h < 0 || h > 23 || m < 0 || m > 59 || s < 0 || s > 59) throw Exception("Error format de hora incorrecte");
    s++;
    if (s >= 60)
    {
        s = 0;
        m++;
        if (m >= 60)
        {
            m = 0;
            h++;
        }
    }
    val formattedString = "${h.toString().padStart(2, '0')}:${m.toString().padStart(2, '0')}:${s.toString().padStart(2, '0')}"
    println(formattedString)

    **/

    /** EXERCICI07
    val sca = Scanner(System.`in`)
    println("Quin es el canvi")
    var preu = sca.nextInt()
    var pagament = sca.nextInt()
    if (preu > pagament) println("Si no hi haguès canvi no es pagués amb prou diners, cal informar d'aquest fet.")
    else
    {
        var n = pagament - preu;
        println("${n / 200} monedes de 2 euros");
        n = n % 200;
        println("${n / 100} monedes de 1 euro");
        n = n % 100;
        println("${n / 50} monedes de 50 centims");
        n = n % 50
        println("${n / 20} monedes de 20 centims");
        n = n % 20
        println("${n / 10} monedes de 10 centims");
        n = n % 10;
        println("${n / 5} monedes de 5 centims");
        n = n % 5;
        println("${n / 2} monedes de 2 centims");
        n = n % 2;
        println("${n / 1} monedes de 1 centim");
        n = n % 1;
    }

    **/

    /** EXERCICI08
    val sca = Scanner(System.`in`)
    println("Entra un numero");
    var n = sca.nextInt()
    n++;
    for (i in 1..n)
    {
        for (j in 0..10)
        println("$i X $j = ${i*j}");
    }
    **/

    /** EXERICICI09
    val sca = Scanner(System.`in`)
    println("Entra un numero");
    var n = sca.nextInt()
    for (i in 1..n)
    {
        var r = 0;
        for (j in 1..i)
        {
            print(j);
            if (j < i) { print(" + "); }
            r += j;
        }
        println(" = "+ r);

    }
    **/

    /** EXERCICI10
    val sca = Scanner(System.`in`)
    var n1 = sca.nextInt()
    var n2 = sca.nextInt()
    while (n2 != 0)
    {
        var aux = n2;
        n2 = n1 % n2;
        n1 = aux;
    }

    println(n1)
    **/
    /** EXERCICI11
    val sca = Scanner(System.`in`)
    println("Entra un numero");
    var n = sca.nextInt()
    var n1 = 0
    var n2 = 1

    for (i in 0..n)
    {
        print("$n1 ");
        var aux = n1;
        n1 = n2;
        n2 += aux;
    }

    println()
    **/


    /**EXERCICI12
    val sca = Scanner(System.`in`)
    var sortir = false;
    do
    {
        println("1. Calcular la longitud d'una circumferència.");
        println("2. Calcular l'àrea d'un cercle.");
        println("3. Calcular el volum d'una esfera.");
        println("4. Sortir.");

        var opcio = sca.nextInt()

        when (opcio)
        {
            1 ->{
                println("Introdueix el radi: ");
                var radi = sca.nextInt()
                var r = 2 * Math.PI * radi;
                println("La longitud de la circumferencia es: $r");
            }
            2 -> {
                println("Introdueix el radi: ");
                var radi = sca.nextInt()
                var r = Math.PI * radi * radi;
                println("L'area del cercle es: $r")
            }
            3 ->{
                println("Introdueix el radi: ");
                var radi = sca.nextInt()
                var r = (4.0 / 3.0) * Math.PI * radi * radi * radi;
                println("El volum de l'esfera es: $r")
            }
            4 -> {
                sortir = true
            }
            else -> println("Opció no vàlida. Torna a intentar.");
        }
    } while (!sortir);
    **/

    /** EXERCICI13
    val sca = Scanner(System.`in`)
    println("De minuscula a majuscula");
    var lletra = sca.nextLine()
    var lletra2 = lletra.uppercase(Locale.getDefault())
    println();
    println("La majúscula corresponent és: $lletra2")
    **/
    // Try adding program arguments via Run/Debug configuration.
    // Learn more about running applications: https://www.jetbrains.com/help/idea/running-applications.html.
    println("Program arguments: ${args.joinToString()}")
}
