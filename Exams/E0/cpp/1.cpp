#include<stdlib.h>
#include<string.h>

namespace ta1
{

bool HasRL(char *queue, int size)
{
    for (size_t i = 0; i < size; i++)
        if (queue[i] == 'R' && queue[i + 1] == 'L')
            return true;
    return false;
}

int solve(const char *queue_orig)
{
    int res = 0;
    int size = strlen(queue_orig);
    char* queue = (char*) malloc(size + 1);
    strcpy(queue, queue_orig);

    while (HasRL(queue, size))
    {
        int i = 0;
        while (i < size)
        {
            if (queue[i] == 'R' && queue[i + 1] == 'L')
            {
                queue[i] = 'L';
                queue[i + 1] = 'R';
                i = i + 1;
            }
            i = i + 1;
        }
        res = res + 1;
    }
    return res;
}

} // namespace ta1