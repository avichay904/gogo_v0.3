<%@ Page Title="" Language="C#" MasterPageFile="~/Administretor/admin3.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="gogo_v0._3.Administretor.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">

    <table id="sudoku">
    </table>
    <button onclick="solve()">Solve</button>
    <script>
        function createSudoku() {
            var board = [];
            for (var i = 0; i < 9; i++) {
                board[i] = [];
                for (var j = 0; j < 9; j++) {
                    board[i][j] = 0;
                }
            }
            return board;
        }

        function printSudoku(board) {
            var table = document.getElementById("sudoku");
            table.innerHTML = "";
            for (var i = 0; i < 9; i++) {
                var row = table.insertRow(i);
                for (var j = 0; j < 9; j++) {
                    var cell = row.insertCell(j);
                    cell.contentEditable = "true";
                    cell.setAttribute("maxLength", "1");
                    if ((i < 3 && j < 3) || (i >= 3 && i < 6 && j >= 3 && j < 6) || (i >= 6 && j >= 6)) {
                        cell.style.backgroundColor = "#F0F0F0";
                    } else {
                        cell.style.backgroundColor = "#FFFFFF";
                    }
                    if (board[i][j] !== 0) {
                        cell.innerText = board[i][j];
                        cell.contentEditable = "false";
                        cell.style.color = "#808080";
                    }
                }
            }
        }

        function solve() {
            var board = getBoard();
            if (isValidSudoku(board)) {
                if (solveSudoku(board)) {
                    printSudoku(board);
                } else {
                    alert("There is no solution!");
                }
            } else {
                alert("Invalid sudoku!");
            }
        }

        function getBoard() {
            var board = createSudoku();
            var table = document.getElementById("sudoku");
            for (var i = 0; i < 9; i++) {
                for (var j = 0; j < 9; j++) {
                    var cell = table.rows[i].cells[j];
                    if (cell.innerText !== "") {
                        board[i][j] = parseInt(cell.innerText);
                    }
                }
            }
            return board;
        }

        function isValidSudoku(board) {
            var rows = [];
            var columns = [];
            var boxes = [];

            for (var i = 0; i < 9; i++) {
                rows[i] = [];
                columns[i] = [];
                boxes[i] = [];
            }

            for (var i = 0; i < 9; i++) {
                for (var j = 0; j < 9; j




</asp:Content>
