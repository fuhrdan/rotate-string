//*****************************************************************************
//** 796. Rotate String     leetcode                                         **
//*****************************************************************************


bool rotateString(char* s, char* goal) {
    int lenS = strlen(s);
    int lenGoal = strlen(goal);

    // If the lengths of s and goal are not equal, goal cannot be a rotation of s
    if (lenS != lenGoal) {
        return false;
    }

    // Create a new string that is s concatenated with itself
    char doubleS[2 * lenS + 1];
    strcpy(doubleS, s);
    strcat(doubleS, s);

    // Check if goal is a substring of doubleS
    return strstr(doubleS, goal) != NULL;
}