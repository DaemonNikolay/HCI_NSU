from typing import List
from prettytable import PrettyTable


def generate_z(C: List[int]) -> str:
    z: str = ""
    for i, element in enumerate(C):
        if i != 0:
            z += f"{' -' if element < 0 else ' +'} {abs(element)}*x{i+1}"
        elif i == 0:
            z = f"{element}*x{i+1}"

    return z


def generate_system_equations(A: List[List[int]], B: List[int]) -> List[str]:
    system_equations: List[str] = []
    result: str = ""
    for i, elements in enumerate(A):
        for j, element in enumerate(elements):
            if j != 0:
                result += f"{' -' if element < 0 else ' +'} {abs(element)}*x{j+1}"
            elif j == 0:
                result = f"{element}*x{j+1}"
        result += f" <= {B[i]}"
        system_equations.append(result)

    return system_equations


def generate_x_zero(count_x: int) -> List[str]:
    result: List[str] = []
    for i in range(1, count_x + 1):
        result.append(f"x{i} >= 0")

    return result


def solution_task(A: List[List[int]], B: List[int], C: List[int]) -> PrettyTable:
    length_columns: int = 0
    length_rows: int = 0

    length_columns = len(A[0]) + len(B)
    length_rows = len(A) + 2

    first_table: PrettyTable = PrettyTable()

    names_columns: List[str] = []
    for i in range(length_columns):
        names_columns.append(f"T{i+1}")
    names_columns.append("B")

    first_table.field_names = names_columns

    row: List[float] = []
    for i, elements in enumerate(A):
        row.clear()
        for element in elements:
            row.append(element)
        for j in range(0, len(B)):
            row.append(1 if i == j else 0)
        row.append(B[i])

        first_table.add_row(row)

    row.clear()
    for element in C:
        row.append(-1 * element)
    for i in range(0, len(B) + 1):
        row.append(0)

    first_table.add_row(row)

    return first_table


if __name__ == '__main__':
    A: List[List[int]] = [
        [5, 2, 7, 6, 8, 7, 9],
        [7, 4, 8, 5, 7, 6, 4],
        [3, 4, 7, 3, 5, 8, 9],
        [9, 3, 6, 5, 3, 9, 6]
    ]

    B: List[int] = [215, 220, 270, 260]
    C: List[int] = [8, 5, 7, 8, 6, 9, 8]

    print(f"z = {generate_z(C)} \n")
    for element in generate_system_equations(A, B):
        print(element)
    print('\n')
    for element in generate_x_zero(len(B)):
        print(element)
    print('\n')
    print(solution_task(A, B, C))
