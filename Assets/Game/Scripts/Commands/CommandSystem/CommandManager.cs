using System;

namespace Game.Scripts.Commands.CommandSystem
{
    public static class CommandManager
    {
        public static void Fire(ICommand command)
        {
            command.Execute();
        }

        public static void Fire<T>() where T : ICommand
        {
            Fire((ICommand) Activator.CreateInstance(typeof(T)));
        }
    }
}