using BusinessLogic.BusinessLogic;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;

namespace UserInterface
{
    public class RaportPrinter
    {
        AppliedServiceBL bl;
        public async Task PrintReportFromCaseAsync(UiCase caseToPrint)
        {
            bl = new AppliedServiceBL();
            StringBuilder reportContent = new StringBuilder();
            double totalHoursWorked = 0;
            double totalKilometersDriven = 0;
            List<UiAppliedService> printServices = new List<UiAppliedService>();
            reportContent.AppendLine($"Case Report: {caseToPrint.CaseName}");
            reportContent.AppendLine($"Description: {caseToPrint.CaseDescription}");
            reportContent.AppendLine($"Start Date: {caseToPrint.StartDate.ToShortDateString()}");
            reportContent.AppendLine($"Estimated End Date: {caseToPrint.EstimatedEndDate.ToShortDateString()}");
            reportContent.AppendLine($"Case Closed: {caseToPrint.CaseClosed}");
            reportContent.AppendLine();
            foreach (UiAppliedService service in caseToPrint.AppliedServices)
            {
                printServices.Add(await bl.GetOneAsync(service.Id));
            }
            reportContent.AppendLine("Applied Services:");
            foreach (UiAppliedService service in printServices)
            {
                reportContent.AppendLine($"- Service: {service.Service.ServiceName}");
                reportContent.AppendLine($"  Description: {service.Service.Description}");
                reportContent.AppendLine($"  Date Performed: {service.ServicePerformed.ToShortDateString()}");
                reportContent.AppendLine($"  Note: {service.Note}");
                reportContent.AppendLine($"  Unit Count: {service.UnitCount}");
                reportContent.AppendLine($"  Unit Cost Actual: {service.UnitCostActual}");
                reportContent.AppendLine($"  Start Payment Actual: {service.StartPaymentActual}");
                reportContent.AppendLine();
            }

            reportContent.AppendLine("Totals:");
            reportContent.AppendLine($"Total Hours Worked: {totalHoursWorked}");
            reportContent.AppendLine($"Total Kilometers Driven: {totalKilometersDriven}");

            await SaveReportToFileAsync(reportContent.ToString());
        }
        private async Task SaveReportToFileAsync(string reportContent)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Save Report",
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = "txt",
                AddExtension = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                await File.WriteAllTextAsync(filePath, reportContent);
                MessageBox.Show("Report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
