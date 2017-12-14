using System;
public class Boolean
{
    // Boolean�� � ���� ��(true)����, ����(false)���� �Ǵ��ϴ� ���̴�.
    // ���߿� if���� for���� ����ϱ� ���� �ʿ��ϴ� �˾ƺ���.
    static void Main()
    {
        // ���� if���� for������ ���� ������(<, <=, >, >=, ==, !=)�� ����Ѵ�.
        // ���� �����ڴ� ������ �ε�ȣ�� ����. (but ==�� �� ���� ���� ��, !=�� �� ���� �ٸ� �� true�̴�.)
        Console.WriteLine("10 < 20: " + (10 < 20));
        Console.WriteLine("10 <= 20: " + (10 <= 20));
        Console.WriteLine("10 > 20: " + (10 > 20));
        Console.WriteLine("10 >= 20: " + (10 >= 20));
        Console.WriteLine("10 == 20: " + (10 == 20));
        Console.WriteLine("10 != 20: " + (10 != 20));

        // �� �����ڴ� �� boolean ���� ���� �� ���� true���� false���� �����ϴ� ���̴�.
        // �� �����ڿ��� ||, &&, ^, ! �� �ִ�.

        // ||�� OR �����̶�� �Ѵ�. �� ���� �ϳ��� true��� true�� ��ȯ�Ѵ�.
        Console.WriteLine("\ntrue || true: " + (true || true));
        Console.WriteLine("true || false: " + (true || false));
        Console.WriteLine("false || true: " + (false || true));
        Console.WriteLine("false || false: " + (false || false));

        // &&�� AND �����̶�� �Ѵ�. �� �� �� true��� true�� ��ȯ�Ѵ�.
        Console.WriteLine("\ntrue && true: " + (true && true));
        Console.WriteLine("true && false: " + (true && false));
        Console.WriteLine("false && true: " + (false && true));
        Console.WriteLine("false && false: " + (false && false));

        // ^�� XOR �����̶�� �Ѵ�. �� �� �� �� �ĸ� true��� true�� ��ȯ�Ѵ�.
        Console.WriteLine("\ntrue ^ true: " + (true ^ true));
        Console.WriteLine("true ^ false: " + (true ^ false));
        Console.WriteLine("false ^ true: " + (false ^ true));
        Console.WriteLine("false ^ false: " + (false ^ false));

        // !�� NOT �����̶�� �Ѵ�. true��� false��, false��� true�� ������Ų��.
        Console.WriteLine("\n!true: " + !true);
        Console.WriteLine("!false: " + !false);

        // �� ���� �����ڿ� �� �����ڸ� �̿��Ͽ� ������ boolean�� ������ �������� �� �� �ִ�.
        // ���� ��� n�̶�� ������ 3�� 5�� ����̸鼭 2�� ����� �ƴ��� Ȯ���غ���.
        int n = 30;
        Console.WriteLine("\nn(30)�� 3�� 5�� ����̸鼭 2�� ����� �ƴѰ�?: " + (n % 3 == 0 && n % 5 == 0 && !(n % 2 == 0)));
        n = 15;
        Console.WriteLine("n(15)�� 3�� 5�� ����̸鼭 2�� ����� �ƴѰ�?: " + (n % 3 == 0 && n % 5 == 0 && !(n % 2 == 0)));
        n = 10;
        Console.WriteLine("n��(10) 3�� 5�� ����̸鼭 2�� ����� �ƴѰ�?: " + (n % 3 == 0 && n % 5 == 0 && !(n % 2 == 0)));

        Console.ReadKey();
    }

}