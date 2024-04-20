'Title:         Vehile Home Office
'Author:        Terry Holmes
'Date:          10-12-15

'Description:   This application is used to enter the home office for the all of the vehicles

Option Strict On

Public Class Form1

    'setting up global variables
    Private TheEmployeeDataTier As EmployeeDataTier
    Private TheEmployeeDataSet As EmployeeDataSet
    Private WithEvents TheEmployeeBindingSource As BindingSource

    Private TheVehiclesDataTier As VehiclesDataTier
    Private TheVehiclesDataSet As VehiclesDataSet
    Private WithEvents TheVehiclesBindingSource As BindingSource

    'Setting up structrue
    Structure Warehouses
        Dim mintEmployeeID As Integer
        Dim mstrLastName As String
        Dim mstrFirstName As String
    End Structure

    Dim structWarehouses() As Warehouses
    Dim mintWarehouseCounter As Integer
    Dim mintWarehouseUpperLimit As Integer

    'structure for failure
    Structure DataEntryFailure
        Dim mintVehicleID As Integer
        Dim mintBJCNumnber As Integer
        Dim mstrHomeOffice As String
        Dim mstrYear As String
        Dim mstrMake As String
        Dim mstrModel As String
    End Structure

    Dim structDataEntryFailure() As DataEntryFailure
    Dim mintFailureCounter As Integer
    Dim mintFailureUpperLimit As Integer
    Dim mblnDataEntryFailure As Boolean

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will Close the program
        CloseProgram.ShowDialog()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will load when the form is loaded
        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim strLastNameForSearch As String
        Dim strLastNameFromTable As String
        Dim row() As String

        'Try Catch for exceptions
        Try

            'Performing the Employee data bindings
            TheEmployeeDataTier = New EmployeeDataTier
            TheEmployeeDataSet = TheEmployeeDataTier.GetEmployeeInformation
            TheEmployeeBindingSource = New BindingSource

            'Setting up the binding source
            With TheEmployeeBindingSource
                .DataSource = TheEmployeeDataSet
                .DataMember = "employees"
                .MoveFirst()
                .MoveLast()
            End With

            'setting the combo box
            With cboEmployeeID
                .DataSource = TheEmployeeBindingSource
                .DisplayMember = "EmployeeID"
                .DataBindings.Add("text", TheEmployeeBindingSource, "EmployeeID", False, DataSourceUpdateMode.Never)
            End With

            'setting the rest of the controls
            txtFirstName.DataBindings.Add("text", TheEmployeeBindingSource, "FirstName")
            txtLastName.DataBindings.Add("Text", TheEmployeeBindingSource, "LastName")

            'getting ready to fill the structure
            intNumberOfRecords = cboEmployeeID.Items.Count - 1
            ReDim structWarehouses(intNumberOfRecords)
            mintWarehouseCounter = 0
            strLastNameForSearch = "WAREHOUSE"

            'beginning loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboEmployeeID.SelectedIndex = intCounter

                'getting the last name
                strLastNameFromTable = txtLastName.Text

                'if statements
                If strLastNameForSearch = strLastNameFromTable Then

                    'loading the structure
                    structWarehouses(mintWarehouseCounter).mintEmployeeID = CInt(cboEmployeeID.Text)
                    structWarehouses(mintWarehouseCounter).mstrFirstName = txtFirstName.Text
                    structWarehouses(mintWarehouseCounter).mstrLastName = txtLastName.Text
                    mintWarehouseCounter += 1

                End If

            Next

            'setting up the variables
            mintWarehouseUpperLimit = mintWarehouseCounter - 1
            mintWarehouseCounter = 0

            'setting the vehicle data variables
            TheVehiclesDataTier = New VehiclesDataTier
            TheVehiclesDataSet = TheVehiclesDataTier.GetVehiclesInformation
            TheVehiclesBindingSource = New BindingSource

            'Setting up the binding source
            With TheVehiclesBindingSource
                .DataSource = TheVehiclesDataSet
                .DataMember = "vehicles"
                .MoveFirst()
                .MoveLast()
            End With

            'setting up the combo box
            With cboVehicleID
                .DataSource = TheVehiclesBindingSource
                .DisplayMember = "VehicleID"
                .DataBindings.Add("Text", TheVehiclesBindingSource, "VehicleID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtBJCNumber.DataBindings.Add("Text", TheVehiclesBindingSource, "BJCNumber")
            txtHomeOffice.DataBindings.Add("text", TheVehiclesBindingSource, "HomeOffice")
            txtMake.DataBindings.Add("text", TheVehiclesBindingSource, "Make")
            txtModel.DataBindings.Add("Text", TheVehiclesBindingSource, "Model")
            txtYear.DataBindings.Add("Text", TheVehiclesBindingSource, "Year")
            txtEmployeeID.DataBindings.Add("text", TheVehiclesBindingSource, "EmployeeID")

            'setting up the grid view
            dgvVehicles.ColumnCount = 6
            dgvVehicles.Columns(0).Name = "Vehicle ID"
            dgvVehicles.Columns(0).Width = 75
            dgvVehicles.Columns(1).Name = "BJC Number"
            dgvVehicles.Columns(1).Width = 75
            dgvVehicles.Columns(2).Name = "Home Office"
            dgvVehicles.Columns(2).Width = 100
            dgvVehicles.Columns(3).Name = "Year"
            dgvVehicles.Columns(3).Width = 75
            dgvVehicles.Columns(4).Name = "Make"
            dgvVehicles.Columns(4).Width = 100
            dgvVehicles.Columns(5).Name = "Model"
            dgvVehicles.Columns(5).Width = 100

            'Getting ready to load up the grid
            intNumberOfRecords = cboVehicleID.Items.Count - 1
            ReDim structDataEntryFailure(intNumberOfRecords)

            'Getting ready to do loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboVehicleID.SelectedIndex = intCounter

                'loading data grid
                row = New String() {cboVehicleID.Text, txtBJCNumber.Text, txtHomeOffice.Text, txtYear.Text, txtMake.Text, txtModel.Text}
                dgvVehicles.Rows.Add(row)

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim intWarehouseCounter As Integer
        Dim intGridCounter As Integer
        Dim intGridNumberOfRecords As Integer
        Dim strHomeOfficeForSearch As String
        Dim strHomeOfficeFromTable As String = ""
        Dim blnHomeOfficeDoesNotMatch As Boolean
        Dim intVehicleCounter As Integer
        Dim intVehicleNumberOfRecords As Integer
        Dim intVehicleIDForSearch As Integer
        Dim intVehicleIDFromTable As Integer
        Dim intEmployeeID As Integer
        Dim rows() As String

        PleaseWait.Show()

        'getting ready for the loop
        intGridNumberOfRecords = dgvVehicles.RowCount - 2
        intVehicleNumberOfRecords = cboVehicleID.Items.Count - 1
        mintFailureCounter = 0
        mblnDataEntryFailure = False

        'Beginning loop
        For intGridCounter = 0 To intGridNumberOfRecords

            blnHomeOfficeDoesNotMatch = True

            strHomeOfficeForSearch = dgvVehicles.Rows(intGridCounter).Cells(2).Value.ToString.ToUpper

            'Loop for warehouse structure
            For intWarehouseCounter = 0 To mintWarehouseUpperLimit

                'validating the home office
                strHomeOfficeFromTable = structWarehouses(intWarehouseCounter).mstrFirstName

                If strHomeOfficeForSearch = strHomeOfficeFromTable Then

                    intEmployeeID = structWarehouses(intWarehouseCounter).mintEmployeeID
                    blnHomeOfficeDoesNotMatch = False
                    intVehicleIDForSearch = CInt(dgvVehicles.Rows(intGridCounter).Cells(0).Value.ToString)

                    'beginning vehicle loop
                    For intVehicleCounter = 0 To intVehicleNumberOfRecords

                        'incrementing the combo box
                        cboVehicleID.SelectedIndex = intVehicleCounter

                        intVehicleIDFromTable = CInt(cboVehicleID.Text)

                        If intVehicleIDForSearch = intVehicleIDFromTable Then

                            'try catch for exceptions
                            Try

                                'editing and saving the record
                                txtHomeOffice.Text = dgvVehicles.Rows(intGridCounter).Cells(2).Value.ToString.ToUpper
                                txtAvailable.Text = "YES"
                                txtEmployeeID.Text = CStr(intEmployeeID)
                                TheVehiclesBindingSource.EndEdit()
                                TheVehiclesDataTier.UpdateDB(TheVehiclesDataSet)

                            Catch ex As Exception
                                MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If
                    Next

                End If

            Next

            If blnHomeOfficeDoesNotMatch = True Then

                mblnDataEntryFailure = True

                'this will load the failure structure
                structDataEntryFailure(mintFailureCounter).mintVehicleID = CInt(dgvVehicles.Rows(intGridCounter).Cells(0).Value.ToString)
                structDataEntryFailure(mintFailureCounter).mintBJCNumnber = CInt(dgvVehicles.Rows(intGridCounter).Cells(1).Value.ToString)
                structDataEntryFailure(mintFailureCounter).mstrHomeOffice = dgvVehicles.Rows(intGridCounter).Cells(2).Value.ToString.ToUpper
                structDataEntryFailure(mintFailureCounter).mstrMake = dgvVehicles.Rows(intGridCounter).Cells(3).Value.ToString.ToUpper
                structDataEntryFailure(mintFailureCounter).mstrModel = dgvVehicles.Rows(intGridCounter).Cells(4).Value.ToString.ToUpper
                structDataEntryFailure(mintFailureCounter).mstrYear = dgvVehicles.Rows(intGridCounter).Cells(5).Value.ToString.ToUpper
                mintFailureCounter += 1

            End If

        Next

        PleaseWait.Close()

        If blnHomeOfficeDoesNotMatch = True Then

            MessageBox.Show("Home Office Entered for the Following Transaction is not Valid", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mintFailureUpperLimit = mintFailureCounter - 1
            dgvVehicles.Rows.Clear()

            'beginning another loop
            For intGridCounter = 0 To mintFailureUpperLimit

                'this will load the structure
                rows = New String() {CStr(structDataEntryFailure(intGridCounter).mintVehicleID), CStr(structDataEntryFailure(intGridCounter).mintBJCNumnber), structDataEntryFailure(intGridCounter).mstrHomeOffice, structDataEntryFailure(intGridCounter).mstrYear, structDataEntryFailure(intGridCounter).mstrMake, structDataEntryFailure(intGridCounter).mstrModel}
                dgvVehicles.Rows.Add(rows)

            Next
        Else
            MessageBox.Show("All Records Have Been Updated, There Are No Failures", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvVehicles.Rows.Clear()
        End If

    End Sub
End Class
