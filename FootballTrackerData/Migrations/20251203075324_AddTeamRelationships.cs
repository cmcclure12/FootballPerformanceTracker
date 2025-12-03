using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballTrackerData.Migrations
{
    /// <inheritdoc />
    public partial class AddTeamRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "playerMatchPerformances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Player",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Match",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_playerMatchPerformances_MatchId",
                table: "playerMatchPerformances",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_playerMatchPerformances_PlayerId",
                table: "playerMatchPerformances",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamId",
                table: "Player",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_TeamId",
                table: "Match",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Team_TeamId",
                table: "Match",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Team_TeamId",
                table: "Player",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_playerMatchPerformances_Match_MatchId",
                table: "playerMatchPerformances",
                column: "MatchId",
                principalTable: "Match",
                principalColumn: "MatchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_playerMatchPerformances_Player_PlayerId",
                table: "playerMatchPerformances",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Team_TeamId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Team_TeamId",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_playerMatchPerformances_Match_MatchId",
                table: "playerMatchPerformances");

            migrationBuilder.DropForeignKey(
                name: "FK_playerMatchPerformances_Player_PlayerId",
                table: "playerMatchPerformances");

            migrationBuilder.DropIndex(
                name: "IX_playerMatchPerformances_MatchId",
                table: "playerMatchPerformances");

            migrationBuilder.DropIndex(
                name: "IX_playerMatchPerformances_PlayerId",
                table: "playerMatchPerformances");

            migrationBuilder.DropIndex(
                name: "IX_Player_TeamId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Match_TeamId",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "playerMatchPerformances");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Match");
        }
    }
}
