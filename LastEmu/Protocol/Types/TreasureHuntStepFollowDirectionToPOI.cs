using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class TreasureHuntStepFollowDirectionToPOI : TreasureHuntStep
	{
		public const short Id = 461;

		public sbyte direction;

		public uint poiLabelId;

		public override short TypeId
		{
			get
			{
				return 461;
			}
		}

		public TreasureHuntStepFollowDirectionToPOI()
		{
		}

		public TreasureHuntStepFollowDirectionToPOI(sbyte direction, uint poiLabelId)
		{
			this.direction = direction;
			this.poiLabelId = poiLabelId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.direction = reader.ReadSByte();
			this.poiLabelId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.direction);
			writer.WriteVarShort((int)this.poiLabelId);
		}
	}
}