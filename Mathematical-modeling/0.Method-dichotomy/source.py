from prettytable import PrettyTable
import decimal


def function_of_number(value):
    return value ** 4 - 12 * value ** 3 + value ** 2 - 10 * value - 3


if __name__ == '__main__':
    decimal.getcontext().prec = 32
    a = decimal.Decimal(-4)
    b = decimal.Decimal(4)
    limit = 100
    function_a = decimal.Decimal(-1)
    function_b = decimal.Decimal(-1)
    function_c = decimal.Decimal(-1)
    module_ba = decimal.Decimal(-1)
    c = decimal.Decimal(-1)

    table = PrettyTable(["#", "A", "B", "C", "F(A)", "F(B)", "F(C)", "|B-A|"])
    for i in range(0, limit):
        if i != 0:
            a = c if function_a * function_c > 0 else a
            b = c if function_b * function_c > 0 else b

        c = (a + b) / 2
        function_a = function_of_number(a)
        function_b = function_of_number(b)
        function_c = function_of_number(c)
        module_ba = abs(b - a)
        table.add_row([i + 1, a, b, c, function_a, function_b, function_c, module_ba])

    print(table)

    output_file = open('table.txt', 'w')
    output_file.write(table.get_string())
    output_file.close()
