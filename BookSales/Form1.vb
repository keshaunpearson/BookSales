'Project:     CH03HandsOn
'Programmer:  KeShaun Pearson
'Date:        7/25/2021
'Description: This project inputs sales information for books.
'             It calculates the extended price and discount
'             for a sale and maintains summary information for all sales. 
'             Uses variables, constants, calculations, error handling and a message box to the user. 
'Folder:      C:\Users\kdpea\source\repost
Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    'Declare module-level variables and constants. 
    Private QuantitySumInteger, SaleCountInteger As Integer
    Private DiscountSumDecimal, DiscountedPriceSumDecimal As Decimal

    Const DISCOUNT_RATE_DECIMAL As Decimal = 0.15D


    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'Calculate the price and the discount
        Dim QuantityInteger As Integer
        Dim PriceDecimal, ExtendedPriceDecimal, DiscountDecimal, DiscountedPriceDecimal,
            AverageDiscountDecimal As Decimal

        Try
            'Convert quantity to numeric value
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)

            Try
                'Convert price if quantity was successful.
                PriceDecimal = Decimal.Parse(PriceTextBox.Text)
                'Calculate values for sale
                ExtendedPriceDecimal = QuantityInteger * PriceDecimal
                DiscountDecimal = Decimal.Round((ExtendedPriceDecimal * DISCOUNT_RATE_DECIMAL), 2)
                DiscountedPriceDecimal = ExtendedPriceDecimal - DiscountDecimal

                'Calculate summary values 
                QuantitySumInteger += QuantityInteger
                DiscountSumDecimal += DiscountDecimal
                DiscountedPriceSumDecimal += DiscountedPriceDecimal
                SaleCountInteger += 1
                AverageDiscountDecimal = DiscountSumDecimal / SaleCountInteger

                'Format and display answers for the sale
                ExtendedPriceTextBox.Text = ExtendedPriceDecimal.ToString("C")
                DiscountTextBox.Text = DiscountDecimal.ToString("N")
                DiscountedPriceTextBox.Text = DiscountedPriceDecimal.ToString("C")

                'Format and display summary values
                QuantitySumTextBox.Text = QuantitySumInteger.ToString()
                DiscountSumTextBox.Text = DiscountSumDecimal.ToString("C")
                DiscountAmountSumTextBox.Text = DiscountedPriceSumDecimal.ToString("C")
                AverageDiscountTextBox.Text = AverageDiscountDecimal.ToString("C")


            Catch PriceException As Exception
                'Handle a price exception
                MessageBox.Show("Price must be numeric.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With PriceTextBox
                    .Focus()
                    .SelectAll()

                End With
            End Try


        Catch QuantityException As Exception
            'Handle a quantity exception.
            MessageBox.Show("Quantity must be numeric.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With PriceTextBox
                .Focus()
                .SelectAll()

            End With

        Catch AnException As Exception
            'Handle any other exception (To be handled in same Try as above Exception handler
            MessageBox.Show("Error: " & AnException.Message)
        End Try
    End Sub


    Private Sub ClearSaleButton_Click(sender As Object, e As EventArgs) Handles ClearSaleButton.Click
        'Clear [revious amounts from the form. 

        TitleTextBox.Clear()
        PriceTextBox.Clear()
        ExtendedPriceTextBox.Clear()
        DiscountTextBox.Clear()
        DiscountedPriceTextBox.Clear()
        With QuantityTextBox
            .Clear()
            .Focus()

        End With

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Exit the project

        Me.Close()

    End Sub



End Class
