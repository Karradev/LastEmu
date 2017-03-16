using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayArenaFightPropositionMessage : NetworkMessage
	{
		public const uint Id = 6276;

		public int fightId;

		public double[] alliesId;

		public uint duration;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6276;
			}
		}

		public GameRolePlayArenaFightPropositionMessage()
		{
		}

		public GameRolePlayArenaFightPropositionMessage(int fightId, double[] alliesId, uint duration)
		{
			this.fightId = fightId;
			this.alliesId = alliesId;
			this.duration = duration;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadInt();
			ushort num = reader.ReadUShort();
			this.alliesId = new double[num];
			for (int i = 0; i < num; i++)
			{
				this.alliesId[i] = reader.ReadDouble();
			}
			this.duration = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.fightId);
			writer.WriteShort((short)((int)this.alliesId.Length));
			double[] numArray = this.alliesId;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteDouble(numArray[i]);
			}
			writer.WriteVarShort((int)this.duration);
		}
	}
}