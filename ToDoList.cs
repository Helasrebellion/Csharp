using System;
using System.Collections.Generic;

namespace ToDoList
{
    public class Task
    {
        public string Description { get; set; } // The description of the task
        public bool IsCompleted { get; set; } // Indicates whether the task is completed or not

        public Task(string description)
        {
            Description = description;
            IsCompleted = false; // Initially, the task is not completed
        }

        public void Complete()
        {
            IsCompleted = true; // Marks the task as completed
        }

        public void Display()
        {
            Console.WriteLine((IsCompleted ? "[X] " : "[ ] ") + Description); // Displays the task with a checkbox based on its completion status
        }
    }

    public class ToDoList
    {
        private List<Task> tasks; // A list to store the tasks

        public ToDoList()
        {
            tasks = new List<Task>(); // Initialize the task list
        }

        public void AddTask(string description)
        {
            Task task = new Task(description); // Creates a new Task object
            tasks.Add(task); // Add the task to the list
            Console.WriteLine("Task added: " + description); // Display a message indicating the task was added
        }

        public void DisplayTasks()
        {
            Console.WriteLine("Tasks:"); // Display a heading for the tasks
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found."); // Display a message if no tasks are found
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.Write((i + 1) + ". ");
                    tasks[i].Display(); // Display each task with its corresponding number
                }
            }
        }

        public void CompleteTask(int index)
        {
            if (index >= 1 && index <= tasks.Count) // Check if the given index is within the valid range
            {
                Task task = tasks[index - 1]; // Get the task to be completed
                task.Complete(); // Mark the task as completed
                Console.WriteLine("Task completed: " + task.Description); // Display a message indicating the task was completed
            }
            else
            {
                Console.WriteLine("Invalid task index."); // Display a message if the given index is invalid
            }
        }
    }

    public class Program
    {
        static void Main()
        {
            ToDoList todoList = new ToDoList(); // Create a new instance of the ToDoList class
            
            Console.WriteLine("Welcome to the ToDo List!");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. Display tasks");
                Console.WriteLine("3. Complete a task");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine(); // Get the user's choice

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the task: ");
                        string task = Console.ReadLine(); // Get the task from the user
                        todoList.AddTask(task); // Add the task to the to-do list
                        break;
                    case "2":
                        todoList.DisplayTasks(); // Display all the tasks in the to-do list
                        break;
                    case "3":
                        Console.Write("Enter the index of the task to complete: ");
                        int index;
                        if (int.TryParse(Console.ReadLine(), out index))
                        {
                            todoList.CompleteTask(index); // Mark the task at the given
