using System.ComponentModel;
using System.Diagnostics;
using ConsoleServiceTool.RepairHub.Persistence.Entities;
using ConsoleServiceTool.RepairHub.Persistence.Entities.Parts;
using ConsoleServiceTool.RepairHub.Services;


namespace ConsoleServiceTool.RepairHub.Views;

public class DataGridSelectionDialog<TService, TViewModel, TEntity, TId> : DataGridSelectionDialogBase
    where TService : Service<TViewModel, TEntity, TId>
    where TViewModel : Model<TId>
    where TEntity : Model<TId>
    where TId : struct
{
    private List<TViewModel> ExcludeModels { get; }
    private readonly TService _service;
    public List<TViewModel> SelectedItems { get; set; }
    public Action<DataGridView>? DataGridViewCustomizer { get; set; }

    public DataGridSelectionDialog(TService service, List<TViewModel>? excludeModels = null)
    {
        _service = service;
        this.btnOK.Click += this.BtnOK_Click;
        this.btnCancel.Click += this.BtnCancel_Click;
        if (excludeModels is { Count: > 0 })
        {
            ExcludeModels = excludeModels;
        }
    }


    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        SetupDataGridView();
        DataGridViewCustomizer?.Invoke(dataGridView1);
    }

    private void SetupDataGridView()
    {
        dataGridView1.AutoGenerateColumns = true;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.MultiSelect = true;
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.ReadOnly = true;

        // Add columns, etc., then bind
        var dataSource = new BindingList<TViewModel>(_service.GetAllExcept(ExcludeModels));
        dataSource.ListChanged += DataSource_ListChanged;
        dataGridView1.DataSource = dataSource;

        dataGridView1.AutoResizeColumns();
    }

    private void DataSource_ListChanged(object? sender, ListChangedEventArgs e)
    {
        // System.Console.Write("Item changed");
        Debug.WriteLine($"Item changed: change type {e.ListChangedType} new index {e.NewIndex} old index {e.OldIndex} item ");
    }

    private void BtnOK_Click(object sender, EventArgs e)
    {
        SelectedItems = dataGridView1.SelectedRows
            .Cast<DataGridViewRow>()
            .Select(row => (TViewModel)row.DataBoundItem)
            .ToList();

        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}

public class PartAttributeSelectionDialog : DataGridSelectionDialog<PartAttributeDefinitionService, PartAttributeDefinitionVM, PartAttributeDefinition, long>
{
    public PartAttributeSelectionDialog(PartAttributeDefinitionService service, List<PartAttributeDefinitionVM>? excludeModels = null)
        : base(service, excludeModels)
    {
    }
}