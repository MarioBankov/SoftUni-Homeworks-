

public static bool solveSudoku(char[][] board)
{
    return solveSudokuCell(0, 0, board);
}


private static bool solveSudokuCell(int row, int col, char[][] board)
{

    if (col == board[row].length)
    {

        col = 0;
        row++;

        
        if (row == board.length)
        {
            return true; 
        }

    }

    
    if (board[row][col] != EMPTY_ENTRY)
    {
        return solveSudokuCell(row, col + 1, board);
    }
    
    for (int value = 1; value <= board.length; value++)
    {

        char charToPlace = (char)(value + '0'); // convert int value to char

        /*
          Apply constraints. We will only add the value to the cell if
          adding it won't cause us to break sudoku rules.
        */
        if (canPlaceValue(board, row, col, charToPlace))
        {
            board[row][col] = charToPlace;
            if (solveSudokuCell(row, col + 1, board))
            { // recurse with our VALID placement
                return true;
            }
        }

    }

    /*
      Undo assignment to this cell. No values worked in it meaning that
      previous states put us in a position we cannot solve from. Hence,
      we backtrack by returning "false" to our caller.
    */
    board[row][col] = EMPTY_ENTRY;
    return false; // No valid placement was found, this path is faulty, return false
}

/*
  Will the placement at (row, col) break the Sudoku properties?
*/
private static boolean canPlaceValue(char[][] board, int row, int col, char charToPlace)
{

    // Check column constraint. For each row, we do a check on column "col".
    for (char[] element : board)
    {
        if (charToPlace == element[col])
        {
            return false;
        }
    }

    // Check row constraint. For each column in row "row", we do a check.
    for (int i = 0; i < board.length; i++)
    {
        if (charToPlace == board[row][i])
        {
            return false;
        }
    }

    /*
      Check region constraints.

      In a 9 x 9 board, we will have 9 sub-boxes (3 rows of 3 sub-boxes).

      The "I" tells us that we are in the Ith sub-box row. (there are 3 sub-box rows)
      The "J" tells us that we are in the Jth sub-box column. (there are 3 sub-box columns)

      I tried to think of better variable names for like 20 minutes but couldn't so just left
      I and J.

      Integer properties will truncate the decimal place so we just know the sub-box number we are in.
      Each coordinate we touch will be found by an offset from topLeftOfSubBoxRow and topLeftOfSubBoxCol.
    */
    int regionSize = (int)Math.sqrt(board.length); // gives us the size of a sub-box

    int I = row / regionSize;
    int J = col / regionSize;

    /*
      This multiplication takes us to the EXACT top left of the sub-box. We keep the (row, col)
      of these values because it is important. It lets us traverse the sub-box with our double for loop.
    */
    int topLeftOfSubBoxRow = regionSize * I; // the row of the top left of the block
    int topLeftOfSubBoxCol = regionSize * J; // the column of the tol left of the block

    for (int i = 0; i < regionSize; i++)
    {
        for (int j = 0; j < regionSize; j++)
        {

            /*
              i and j just define our offsets from topLeftOfBlockRow
              and topLeftOfBlockCol respectively
            */
            if (charToPlace == board[topLeftOfSubBoxRow + i][topLeftOfSubBoxCol + j])
            {
                return false;
            }

        }
    }

    return true; // placement is valid
}