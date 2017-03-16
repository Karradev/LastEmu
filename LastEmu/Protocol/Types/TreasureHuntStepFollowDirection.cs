using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class TreasureHuntStepFollowDirection : TreasureHuntStep
	{
		public const short Id = 468;

		public sbyte direction;

		public uint mapCount;

		public override short TypeId
		{
			get
			{
				return 468;
			}
		}

		public TreasureHuntStepFollowDirection()
		{
		}

		public TreasureHuntStepFollowDirection(sbyte direction, uint mapCount)
		{
			this.direction = direction;
			this.mapCount = mapCount;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.direction = reader.ReadSByte();
			this.mapCount = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.direction);
			writer.WriteVarShort((int)this.mapCount);
		}
	}
}