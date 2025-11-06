#include <iostream>

using namespace std;

int main()
{   
    int vendasMensais[2][13] = {
        {1, 2, 3, 4, 5, 6, 7, 8, 9 , 10, 11, 12},
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
    };

    int i, j, maiorVenda = 0;

    for (j = 0; j <= 12; j++) {
        cin >> vendasMensais[1][j];
    }

    for (j = 0; j <= 12; j++) {
        if (vendasMensais[1][j] > maiorVenda) {
            maiorVenda = vendasMensais[1][j];
        }

    }

    cout << maiorVenda;

    return 0;
}