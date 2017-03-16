using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AbstractGameActionFightTargetedAbilityMessage : AbstractGameActionMessage
	{
		public const uint Id = 6118;

		public bool silentCast;

		public bool verboseCast;

		public double targetId;

		public short destinationCellId;

		public sbyte critical;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6118;
			}
		}

		public AbstractGameActionFightTargetedAbilityMessage()
		{
		}

		public AbstractGameActionFightTargetedAbilityMessage(uint actionId, double sourceId, bool silentCast, bool verboseCast, double targetId, short destinationCellId, sbyte critical) : base(actionId, sourceId)
		{
			this.silentCast = silentCast;
			this.verboseCast = verboseCast;
			this.targetId = targetId;
			this.destinationCellId = destinationCellId;
			this.critical = critical;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			byte num = reader.ReadByte();
			this.silentCast = BooleanByteWrapper.GetFlag(num, 0);
			this.verboseCast = BooleanByteWrapper.GetFlag(num, 1);
			this.targetId = reader.ReadDouble();
			this.destinationCellId = reader.ReadShort();
			this.critical = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.silentCast);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 1, this.verboseCast));
			writer.WriteDouble(this.targetId);
			writer.WriteShort(this.destinationCellId);
			writer.WriteSByte(this.critical);
		}
	}
}