using System.ComponentModel;
using System.Diagnostics;
using ConsoleServiceTool.RepairHub.Persistence;
using ConsoleServiceTool.RepairHub.Persistence.Repositories;
using ConsoleServiceTool.RepairHub.Services;

namespace ConsoleServiceTool.RepairHub.Views
{
    public partial class PartsView : UserControl
    {
        private ApplicationDbContext dbContext;
        private PartAttributeDefinitionService partAttributeDefinitionService;
        private PartDefinitionService partDefinitionService;

        public PartsView()
        {
            InitializeComponent();
            dbContext = new ApplicationDbContext();
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            partAttributeDefinitionService = new PartAttributeDefinitionService(new PartAttributeDefinitionRepository(dbContext));
            partDefinitionService = new PartDefinitionService(new PartDefinitionRepository(dbContext), partAttributeDefinitionService);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dbContext = new ApplicationDbContext();
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();


            this.partDefinitionVMBindingSource.DataSource = partDefinitionService.GetAll();

            // Set up the secondary BindingSource in code.
            partAttributesBindingSource.DataSource = partDefinitionVMBindingSource;
            partAttributesBindingSource.DataMember = "PartAttributes";

            // Bind second DataGrid to the secondary BindingSource.
            dgvAttributes.DataSource = partAttributesBindingSource;
        }

        private void dgvParts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var part = (PartDefinitionVM)dgvParts?.CurrentRow?.DataBoundItem;
                if (part != null)
                {
                    dgvAttributes.DataSource = part.PartAttributes;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Debug.WriteLine($"{ex.Message}");
            }
        }

        private void PartsView_Load(object sender, EventArgs e)
        {
        }

        private void btnAddAttribute_Click(object sender, EventArgs e)
        {
            var attributes = ((BindingList<PartAttributeVM>)dgvAttributes.DataSource)?
                .Cast<PartAttributeDefinitionVM>()
                .ToList();
            var dialog = new PartAttributeSelectionDialog(partAttributeDefinitionService, attributes);

            dialog.DataGridViewCustomizer = view =>
            {
                var cellStyle = new DataGridViewCellStyle();
                cellStyle.BackColor = Color.Beige;
                view.AlternatingRowsDefaultCellStyle = cellStyle;
            };

            var dialogResult = dialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var newAttributes = (BindingList<PartAttributeVM>)dgvAttributes.DataSource ?? [];
                dialog.SelectedItems.ForEach(vm =>
                {
                    var newAttribute = new PartAttributeVM
                    {
                        PartDefinitionId = vm.Id,
                        IsRequired = false,
                        Name = vm.Name,
                        Description = vm.Description
                    };
                    newAttributes.Add(newAttribute);
                });

                var part = (PartDefinitionVM)dgvParts.CurrentRow?.DataBoundItem;
                if (part != null)
                {
                    part.PartAttributes = newAttributes;
                }

                dgvAttributes.DataSource = newAttributes;
            }
        }
    }
}