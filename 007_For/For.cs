using System;
public class For
{
    // for���� �ڵ带 �ݺ� �����ϴ� �ݺ����̴�.
    static void Main()
    {
        // for���� ������ for(�ʱ��; ���ǽ�; ������) {���� ����} �̴�.
        // for���� �۵� ������ �ʱ�� -> ���ǽ��� true��� -> ���� ���� -> ������ -> ���ǽ� -> ���೻��...
        // ���ǽ��� ���Ͽ��� �� false��� ���� ������ �������� �ʰ� for���� �����Ѵ�.
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        // if�� ó�� ���� ������ �� ���̶�� for() ���೻��; ���� �����ϰ� �� �� �ִ�.
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        // for���� if���� �̿��Ͽ� 1���� 20���� �� �߿� ¦���� ����ϴ� �ڵ带 ¥����
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0) Console.WriteLine(i);
        }

        Console.ReadKey();
    }
}