using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightTackledMessage : AbstractGameActionMessage
	{
		public const uint Id = 1004;

		public double[] tacklersIds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1004;
			}
		}

		public GameActionFightTackledMessage()
		{
		}

		public GameActionFightTackledMessage(uint actionId, double sourceId, double[] tacklersIds) : base(actionId, sourceId)
		{
			this.tacklersIds = tacklersIds;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.tacklersIds = new double[num];
			for (int i = 0; i < num; i++)
			{
				this.tacklersIds[i] = reader.ReadDouble();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.tacklersIds.Length));
			double[] numArray = this.tacklersIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteDouble(numArray[i]);
			}
		}
	}
}