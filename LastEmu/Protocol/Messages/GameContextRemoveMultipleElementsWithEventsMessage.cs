using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameContextRemoveMultipleElementsWithEventsMessage : GameContextRemoveMultipleElementsMessage
	{
		public const uint Id = 6416;

		public sbyte[] elementEventIds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6416;
			}
		}

		public GameContextRemoveMultipleElementsWithEventsMessage()
		{
		}

		public GameContextRemoveMultipleElementsWithEventsMessage(double[] id, sbyte[] elementEventIds) : base(id)
		{
			this.elementEventIds = elementEventIds;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = (ushort)reader.ReadVarInt();
			this.elementEventIds = new sbyte[num];
			for (int i = 0; i < num; i++)
			{
				this.elementEventIds[i] = reader.ReadSByte();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)((int)this.elementEventIds.Length));
			sbyte[] numArray = this.elementEventIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteSByte(numArray[i]);
			}
		}
	}
}