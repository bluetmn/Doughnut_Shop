using RazorPagesDoughnuts.Models;

namespace RazorPagesDoughnuts.Services;
public static class DoughnutService {
    static List<Doughnut> Doughnuts { get; }
    static int nextId = 3;
    static DoughnutService() {
        Doughnuts = new List<Doughnut>
                    {
                        new Doughnut { Id = 1, Name = "Birthday Cake", Price = 5.00M, Size = DoughnutSize.Regular, HasGlaze = false},
                        new Doughnut { Id = 2, Name = "Oreo Cream", Price = 6.00M, Size = DoughnutSize.Super, HasGlaze = true}
                    };
    }

    public static List<Doughnut> GetAll() => Doughnuts;

    public static Doughnut? Get(int id) => Doughnuts.FirstOrDefault(p => p.Id == id);

    public static void Add(Doughnut doughnut) {
        doughnut.Id = nextId++;
        Doughnuts.Add(doughnut);
    }

    public static void Delete(int id) {
        var doughnut = Get(id);
        if (doughnut is null)
            return;

        Doughnuts.Remove(doughnut);
    }

    public static void Update(Doughnut doughnut) {
        var index = Doughnuts.FindIndex(p => p.Id == doughnut.Id);
        if (index == -1)
            return;

        Doughnuts[index] = doughnut;
    }
}

