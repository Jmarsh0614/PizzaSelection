'Program Name Pizza Selection
'Developer : Joshua Marshall
'Date : 09 Feb 2017
'Purpose : This application displays two pizza types
'(deep dish and thin crust). The User can select a pizza type

Public Class frmPizzaSelection


    Private Sub btnDeepDish_Click(sender As Object, e As EventArgs) Handles btnDeepDish.Click
        'This code is executed when the user taps or clicks
        'the Deep Dish button. It displays the Deep Dish Picture
        'Hides the Thin Crust picture, and enables the Select
        'Pizza button.
        picDeepDish.Visible = True
        picThinCrust.Visible = False
        btnConfirmation.Enabled = True

    End Sub

    Private Sub btnThinCrust_Click(sender As Object, e As EventArgs) Handles btnThinCrust.Click
        picThinCrust.Visible = True
        picDeepDish.Visible = False
        btnConfirmation.Enabled = True

    End Sub

    Private Sub btnConfirmation_Click(sender As Object, e As EventArgs) Handles btnConfirmation.Click
        'This code is executed when the user taps or clicks the
        'Select Pizza button. It disables the Deep Dish Button, the 
        ' Select Case Pizza button, And the Thin Crust Button
        'It hides the Instructions label, displays the 
        'Confirmation label and enables the Exit Window Button
        btnDeepDish.Visible = False
        btnConfirmation.Visible = False
        btnThinCrust.Visible = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is executed when the user taps or clicks the Exit Window
        'button. It close the window and terminates the program execution. 
        Close()

    End Sub
End Class
