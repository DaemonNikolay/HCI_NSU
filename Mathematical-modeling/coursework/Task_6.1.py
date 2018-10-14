import sys
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


# def solution_task(A: List[List[int]], B: List[int], C: List[int]) -> List[PrettyTable]:
#     length_columns: int = len(A[0]) + len(B)
#     length_rows = len(A)
#     first_table: PrettyTable = PrettyTable()
#
#     names_columns: List[str] = []
#     for i in range(length_columns):
#         names_columns.append(f"T{i+1}")
#     names_columns.append("B")
#
#     first_table.field_names = names_columns
#
#     row: List[float] = []
#     for i, elements in enumerate(A):
#         row.clear()
#         for element in elements:
#             row.append(element)
#         for j in range(0, len(B)):
#             row.append(1 if i == j else 0)
#         row.append(B[i])
#
#         first_table.add_row(row)
#
#     row.clear()
#     for element in C:
#         row.append(-1 * element)
#     for i in range(0, len(B) + 1):
#         row.append(0)
#     first_table.add_row(row)
#
#     tables: List[PrettyTable] = [first_table]
#
#     keys: List[str] = first_table.field_names
#     last_line_first_table: List[float] = []
#
#     temp_first_table = first_table.copy()
#     temp_first_table.border = False
#     temp_first_table.header = False
#
#     for key in keys:
#         last_line_first_table.append(float(temp_first_table[length_rows].get_string(fields=[key])))
#
#     min_value_last_line: float = min(last_line_first_table)
#     position_min_value_last_line: int = last_line_first_table.index(min_value_last_line)
#
#
#
#     optimal_technology: float = float('-inf')
#     for value in B:
#         print(value, temp_first_table.get_string(fields=[keys[position_min_value_last_line]]))
#
#
#     return tables


def generate_primary_table(A: List[List[int]], B: List[int], C: List[int]) -> PrettyTable:
    names_columns: List[str] = []
    for i in range(1, 1 + len(A[0]) + len(B)):
        names_columns.append(f"T{i}")
    names_columns.append("B")

    primary_table: PrettyTable = PrettyTable()
    primary_table.field_names = names_columns

    for index, elements in enumerate(A):
        row: List[float] = []
        for element in elements:
            row.append(float(element))
        for i in range(0, len(B)):
            row.append(float(1 if index == i else 0))
        row.append(B[index])
        primary_table.add_row(row)

    last_row: List[float] = []
    for element in C:
        last_row.append(float(-element))
    for i in range(0, 1 + len(B)):
        last_row.append(float(0))
    primary_table.add_row(last_row)

    return primary_table


def search_min_last_line_primary_table(last_line_primary_table: PrettyTable) -> float:
    return min(last_line_primary_table.__dict__['_rows'][0])


def search_posistion_min_last_line_primary_table(last_line_primary_table: PrettyTable, min_value: float) -> int:
    position_min_value: list = last_line_primary_table.__dict__['_rows'][0]
    return position_min_value.index(min_value)


def search_optimal_technology(primary_table: PrettyTable, count_rows: int, B: List) -> dict:
    copy_primary_table: PrettyTable = primary_table.copy()
    copy_primary_table.header = False
    copy_primary_table.border = False

    last_line_primary_table = copy_primary_table[count_rows]

    min_value_in_last_line_primary_table: float = search_min_last_line_primary_table(last_line_primary_table)
    position_min_value_last_line_primary_table: int = search_posistion_min_last_line_primary_table(
        last_line_primary_table, min_value_in_last_line_primary_table)

    keys: List[str] = copy_primary_table.field_names
    column_with_optimal_technology = copy_primary_table.get_string(
        fields=[keys[position_min_value_last_line_primary_table]])
    list_optimal_technology: List[str] = column_with_optimal_technology.replace(' ', '').split('\n')

    old_value: float = sys.maxsize
    optimal_technology: float = 0
    position_y: int = sys.maxsize
    for i, value in enumerate(B):
        elem_list_optimal_technology = float(list_optimal_technology[i])
        temp = value / elem_list_optimal_technology
        if temp < old_value:
            old_value = temp
            optimal_technology = elem_list_optimal_technology
            position_y = i

    result: dict = {
        "value": optimal_technology,
        "position_x": position_min_value_last_line_primary_table,
        "position_y": position_y
    }

    return result


def formula_recounting(first: float, second: float, optimal_tech: float, diagonal_value: float) -> float:
    return (first * optimal_tech - second * diagonal_value) / optimal_tech


def recounting_tables(primary_table: PrettyTable, optimal_technology: dict) -> PrettyTable:
    copy_table: PrettyTable = primary_table.copy()
    copy_table.border = False
    copy_table.header = False

    names_columns: List[str] = copy_table.field_names
    values_table: List[List[float]] = []
    for index, elements in enumerate(copy_table):
        values_table.append([])
        for name_column in names_columns:
            values_table[index].append(float(elements.get_string(fields=[name_column])))

    table: PrettyTable = PrettyTable()
    table.field_names = copy_table.field_names

    position_optimal_tech_x: int = optimal_technology.get('position_x')
    position_optimal_tech_y: int = optimal_technology.get('position_y')

    file = open('out.txt', 'a')



    for i, elements in enumerate(values_table):
        row: List[float] = []
        for index, element in enumerate(elements):
            first: float = element
            second: float = values_table[position_optimal_tech_y][index]
            optimal_tech: float = optimal_technology.get('value')
            diagonal_value: float = elements[position_optimal_tech_x]
            row.append(formula_recounting(first, second, optimal_tech, diagonal_value))

            # log = f"{position_optimal_tech_y} {index} = { values_table[position_optimal_tech_y][index]}"
            log = f"x{i+1}{index+1} = ({first} * {optimal_tech} - {second} * {diagonal_value}) / {optimal_tech} = {formula_recounting(first, second, optimal_tech, diagonal_value)}"

            file.write(log)
            file.write('\n')
        file.write('\n')
        table.add_row(row)


    print(table)

    file.close()
    breakpoint()

    return table


def select_b_from_final_table(final_table: PrettyTable) -> List[float]:
    copy_table: PrettyTable = final_table.copy()
    copy_table.header = False
    copy_table.border = False
    new_b: str = copy_table.get_string(fields="B")

    list_new_b: List[float] = []
    result: List[float] = []
    for element in new_b.replace(' ', '').split('\n'):
        result.append(float(element))

    return result


def solution_task(A: List[List[int]], B: List[int], C: List[int]) -> List[PrettyTable]:
    primary_table: PrettyTable = generate_primary_table(A, B, C)
    optimal_technology: dict = search_optimal_technology(primary_table, len(B), B)
    final_table: PrettyTable = recounting_tables(primary_table, optimal_technology)

    for i in range(0, 1):
        print(final_table)
        new_b: List[float] = select_b_from_final_table(final_table)
        optimal_technology = search_optimal_technology(final_table, len(B), B)
        # print(optimal_technology)
        # final_table = recounting_tables(final_table, optimal_technology)


if __name__ == '__main__':
    A: List[List[int]] = [
        [5, 2, 7, 6, 8, 7, 9],
        [7, 4, 8, 5, 7, 6, 4],
        [3, 4, 7, 3, 5, 8, 9],
        [9, 3, 6, 3, 3, 9, 6]
    ]

    B: List[int] = [215, 220, 270, 260]
    C: List[int] = [8, 5, 7, 8, 6, 9, 8]

    # print(f"z = {generate_z(C)} \n")
    # for element in generate_system_equations(A, B):
    #     print(element)
    # print('\n')
    # for element in generate_x_zero(len(B)):
    #     print(element)
    # print('\n')

    g = solution_task(A, B, C)
