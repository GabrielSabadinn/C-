﻿using System.ComponentModel;

namespace SystemOfTasks.Enums
{
    public enum StatusTask
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("Em Andamento")]
        EmAndamento = 2,
       [Description("Concluido")]
        Concluido = 3,
    }
}
