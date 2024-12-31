%{
#include<stdio.h>
#include<stdlib.h>
%}
%%
^[0-9]*  printf("It is a digit.");
^[^0-9]|[0-9]*[a-zA-Z]  printf("It is not a digit.");
. ;
%%
int main()
{
    printf("Input:");
        // The function that starts the analysis
    yylex();
        return 0;
}
