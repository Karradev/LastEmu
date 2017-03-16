using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class KohUpdateMessage : NetworkMessage
	{
		public const uint Id = 6439;

		public AllianceInformations[] alliances;

		public uint[] allianceNbMembers;

		public uint[] allianceRoundWeigth;

		public sbyte[] allianceMatchScore;

		public BasicAllianceInformations allianceMapWinner;

		public uint allianceMapWinnerScore;

		public uint allianceMapMyAllianceScore;

		public double nextTickTime;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6439;
			}
		}

		public KohUpdateMessage()
		{
		}

		public KohUpdateMessage(AllianceInformations[] alliances, uint[] allianceNbMembers, uint[] allianceRoundWeigth, sbyte[] allianceMatchScore, BasicAllianceInformations allianceMapWinner, uint allianceMapWinnerScore, uint allianceMapMyAllianceScore, double nextTickTime)
		{
			this.alliances = alliances;
			this.allianceNbMembers = allianceNbMembers;
			this.allianceRoundWeigth = allianceRoundWeigth;
			this.allianceMatchScore = allianceMatchScore;
			this.allianceMapWinner = allianceMapWinner;
			this.allianceMapWinnerScore = allianceMapWinnerScore;
			this.allianceMapMyAllianceScore = allianceMapMyAllianceScore;
			this.nextTickTime = nextTickTime;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.alliances = new AllianceInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.alliances[i] = new AllianceInformations();
				this.alliances[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.allianceNbMembers = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.allianceNbMembers[j] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.allianceRoundWeigth = new uint[num];
			for (int k = 0; k < num; k++)
			{
				this.allianceRoundWeigth[k] = reader.ReadVarUhInt();
			}
			num = (ushort)reader.ReadVarInt();
			this.allianceMatchScore = new sbyte[num];
			for (int l = 0; l < num; l++)
			{
				this.allianceMatchScore[l] = reader.ReadSByte();
			}
			this.allianceMapWinner = new BasicAllianceInformations();
			this.allianceMapWinner.Deserialize(reader);
			this.allianceMapWinnerScore = reader.ReadVarUhInt();
			this.allianceMapMyAllianceScore = reader.ReadVarUhInt();
			this.nextTickTime = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.alliances.Length));
			AllianceInformations[] allianceInformationsArray = this.alliances;
			for (int i = 0; i < (int)allianceInformationsArray.Length; i++)
			{
				allianceInformationsArray[i].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.allianceNbMembers.Length));
			uint[] numArray = this.allianceNbMembers;
			for (int j = 0; j < (int)numArray.Length; j++)
			{
				writer.WriteVarShort((int)numArray[j]);
			}
			writer.WriteShort((short)((int)this.allianceRoundWeigth.Length));
			uint[] numArray1 = this.allianceRoundWeigth;
			for (int k = 0; k < (int)numArray1.Length; k++)
			{
				writer.WriteVarInt((int)numArray1[k]);
			}
			writer.WriteVarInt((int)((int)this.allianceMatchScore.Length));
			sbyte[] numArray2 = this.allianceMatchScore;
			for (int l = 0; l < (int)numArray2.Length; l++)
			{
				writer.WriteSByte(numArray2[l]);
			}
			this.allianceMapWinner.Serialize(writer);
			writer.WriteVarInt((int)this.allianceMapWinnerScore);
			writer.WriteVarInt((int)this.allianceMapMyAllianceScore);
			writer.WriteDouble(this.nextTickTime);
		}
	}
}