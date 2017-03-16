using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class TreasureHuntStepFollowDirectionToHint : TreasureHuntStep
	{
		public const short Id = 472;

		public sbyte direction;

		public uint npcId;

		public override short TypeId
		{
			get
			{
				return 472;
			}
		}

		public TreasureHuntStepFollowDirectionToHint()
		{
		}

		public TreasureHuntStepFollowDirectionToHint(sbyte direction, uint npcId)
		{
			this.direction = direction;
			this.npcId = npcId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.direction = reader.ReadSByte();
			this.npcId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.direction);
			writer.WriteVarShort((int)this.npcId);
		}
	}
}